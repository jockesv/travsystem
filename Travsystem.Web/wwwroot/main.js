(function() {

  'use strict';

  angular.module('travLabApp', ['ui.bootstrap', 'angular-loading-bar', 'ngStorage']);

  angular.module('travLabApp')
    .controller('TravLabController', TravLabController); 

  TravLabController.$inject = ['$scope', '$localStorage', '$modal', '$log', 'USER_ROLES', 'AUTH_EVENTS', 'AuthService', 'dataservice', 'Session', 'OddsRank', 'ABCDReduction', 'Coupon'];

  function TravLabController($scope, $localStorage, $modal, $log, USER_ROLES, AUTH_EVENTS, AuthService, dataservice, Session, OddsRank, ABCDReduction, Coupon) {

    var vm = this;

    vm.isAuthorized = AuthService.isAuthorized;
    vm.baseUrl = "./api";
    vm.laps = null;
    vm.raceDays = [];
    vm.predicate = 'StartNumber';
    vm.selectedRace = null;
    vm.abcdRankSettings = null;
    vm.reducedRows = null;
    vm.cost = 0;
    vm.costMap = {'V75': 0.5, 'V86': 0.25, 'V65': 1, 'V64': 1};

    vm.systemSize = 0;
    vm.reducedRowsSize = 0;
    vm.reductionLevel = 0;
    vm.colorTable = null;

    vm.userName = null;

    vm.ranksEnum = [
    { val: 'A' },
    { val: 'B' },
    { val: 'C' },
    { val: 'D' },
    { val: 'S' }
    ];

    vm.rankStatus = {
      Good: 'good',
      Medium: 'medium',
      Bad: 'bad',
      Disabled: 'disabled'
    };

    vm.val = vm.ranksEnum.A;
    vm.getStatus = getStatus;
    vm.initialize = initialize;
    vm.loadRaceDays = loadRaceDays;
    vm.loadRace = loadRace;
    vm.getBetFile = getBetFile;
    vm.applyABCDRuduction = applyABCDRuduction;
    vm.formatRaceTitle = formatRaceTitle;
    vm.onABCDRankClick = onABCDRankClick;
    vm.login = login;
    vm.logout = logout;
    vm.setCurrentUser = setCurrentUser;
    vm.removeCurrentUser = removeCurrentUser;
    vm.getColorForCell = getColorForCell;
    vm.initialize();

    $scope.$on(AUTH_EVENTS.loginSuccess, vm.setCurrentUser);
    $scope.$on(AUTH_EVENTS.logoutSuccess, vm.removeCurrentUser);

    $scope.$on(AUTH_EVENTS.methodNotAllowed, vm.login);
    $scope.$on(AUTH_EVENTS.sessionTimeout, vm.login)

    $scope.$watch('vm.laps', function (newValue, oldValue) {
      if (newValue != null) {
        vm.abcdRankSettings = OddsRank.ABCDRankSettings(newValue, vm.abcdRankSettings);
        vm.applyABCDRuduction(vm.laps, vm.abcdRankSettings);
      }

    }, true);

    ////////////////////////////////

    function initialize () {
      vm.selectedRace = $localStorage.selectedRace;
      vm.laps = $localStorage.laps;
      vm.abcdRankSettings = $localStorage.abcdRankSettings;
      
      vm.userName = $localStorage.sessionName;
      Session.ticket = $localStorage.sessionTicket;
      Session.name = $localStorage.sessionName;
      Session.role = $localStorage.sessionRole;     

      if (Session.ticket == null) {
        login();
      } 
    }

    function login () {
      var modalInstance = $modal.open({
        templateUrl: 'login.html',
        controller: 'ModalInstanceCtrl',
        size: 'sm',
        backdrop : 'static',
        resolve: {
          items: function () {
              return [];
          }
        }
      });
    }

    function logout () {
      AuthService.logout();
    }

    function  setCurrentUser () {
      vm.userName = Session.name;
      $localStorage.sessionTicket = Session.ticket;
      $localStorage.sessionName = Session.name;
      $localStorage.sessionRole = Session.role;
    }

    function removeCurrentUser() {
      vm.userName = null;
      vm.selectedRace = null;
      vm.laps = null;
      vm.abcdRankSettings = null;

      $localStorage.abcdRankSettings = null;
      $localStorage.laps = null;
      $localStorage.selectedRace = null;

      $localStorage.sessionTicket = null;
      $localStorage.sessionName = null;
      $localStorage.sessionRole = null;
    }

    function loadRaceDays () {
      dataservice.loadRaceDays(vm.baseUrl)
      .then(function(data) {
        vm.raceDays = data;
      });
    }

    function loadRace (race) {
      dataservice.loadRace(vm.baseUrl, race)
        .then(function(data) {
          vm.selectedRace = race;
          vm.laps = data;

          $localStorage.selectedRace = race;
          $localStorage.laps = data;

          OddsRank.Rank(data);
        });
    }

    function getBetFile () {
      dataservice.getBetFile( 
        vm.baseUrl, 
        vm.selectedRace, 
        Coupon.CreateMarks(vm.reducedRows), 
        vm.systemSize, 
        vm.reducedRowsSize)
        .then(function(data) {
          if (data !== undefined) {
            var blob = new Blob([data.xml], { type: "text/xml;charset=utf-8" });
            saveAs(blob, data.filename);  
          }          
        });
    }

    function getStatus(horse) {
      if (!horse.enabled) {
        return vm.rankStatus.Disabled;
      }
      else if (horse.odds < 5) {
        return vm.rankStatus.Good;
      }
      else if (horse.odds >= 5 && horse.odds < 10) {
        return vm.rankStatus.Medium;
      }
      else {
        return vm.rankStatus.Bad;
      }
    }

    function  formatRaceTitle (race) {
      if (race != null) {
        var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' },
            date = new Date(race.year, race.month - 1, race.date);
        return race.betType + ' ' + date.toLocaleDateString("sv-SE", options);
      } else {
        return "";
      }
    }

    function onABCDRankClick (row, col) {
      var first = Enumerable.From(row.content).Where(function (x) { return x.selected == true; }).FirstOrDefault();
      var last = Enumerable.From(row.content).Where(function (x) { return x.selected == true; }).LastOrDefault();

      if (col.selected) {
        if (col == first || col == last) {
          col.selected = false;
        }
      } else {
        if (first == null && last == null) {
          col.selected = true;
        } else {
          var prevCol = null;
          angular.forEach(row.content, function (x) {
            if (x.selected && prevCol == col) {
              col.selected = true;
            } else if (prevCol != null && prevCol.selected && x == col) {
              col.selected = true;
            }
            prevCol = x;
          });
        }
      }

      vm.applyABCDRuduction(vm.laps, vm.abcdRankSettings);
      $localStorage.abcdRankSettings = vm.abcdRankSettings;
    }

    function applyABCDRuduction (laps, abcdSettings) {
      var singleRows = Coupon.GenerateSingleRows(laps);
      var rank_a = Enumerable.From(abcdSettings[0].content).Where(function (x) { return x.selected; }).Select(function (x) { return x.value; });
      var rank_b = Enumerable.From(abcdSettings[1].content).Where(function (x) { return x.selected; }).Select(function (x) { return x.value; });
      var rank_c = Enumerable.From(abcdSettings[2].content).Where(function (x) { return x.selected; }).Select(function (x) { return x.value; });
      var rank_d = Enumerable.From(abcdSettings[3].content).Where(function (x) { return x.selected; }).Select(function (x) { return x.value; });

      vm.reducedRows = ABCDReduction.Reduce (
        rank_a.Any() ? Coupon.Span(rank_a.Min(), rank_a.Max()) : Coupon.Span(0, 0),
        rank_b.Any() ? Coupon.Span(rank_b.Min(), rank_b.Max()) : Coupon.Span(0, 0),
        rank_c.Any() ? Coupon.Span(rank_c.Min(), rank_c.Max()) : Coupon.Span(0, 0),
        rank_d.Any() ? Coupon.Span(rank_d.Min(), rank_d.Max()) : Coupon.Span(0, 0),
        singleRows
      );

      vm.systemSize = singleRows.length;
      vm.reducedRowsSize = vm.reducedRows.length;
      vm.reductionLevel = vm.systemSize > 0 ? Math.round(((vm.systemSize - vm.reducedRowsSize) / vm.systemSize) * 100.0) : 0;
      vm.colorTable = Coupon.GetColorTable(vm.reducedRows);
      vm.cost = vm.reducedRowsSize * vm.costMap[vm.selectedRace.betType];
    }

    function getColorForCell (row, col) {
      
      var hexColor = '#ffffff';

      if (vm.colorTable != null && vm.systemSize > 0) {
        var value = vm.colorTable[row.number][col.startNumber];
        if (value > 0) {
          var factor = 255 / vm.reducedRowsSize;
          var color = Math.round(factor * value);
          color = 255 - color;
          var hex = color.toString(16);
          hex = hex.length == 1 ? hex = '0' + hex : hex;
          hexColor = '#ff' + hex + '00';
        }
      } 

      return {'background-color': hexColor};
    }
  }
})();
