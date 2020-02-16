(function() {
	
	'use strict';

	angular
		.module('travLabApp')
		.factory('OddsRank', OddsRank);

	function OddsRank() {
		var service = {
			Rank: Rank,
			ABCDRankSettings: ABCDRankSettings
		};

		return service;

		////////////////////

		function Rank(legs) {

			angular.forEach(legs, function(leg) {
				var scratchedHorses = Enumerable.From(leg.horses).Where(function(horse) { return horse.enabled == false; }).ToArray();
				angular.forEach(scratchedHorses, function(scratchedHorse) {
					scratchedHorse.rankTal = 9999999;
					scratchedHorse.rankOrder = 9999999;
				});

				var horses = Enumerable.From(leg.horses).Where(function(horse) { return horse.enabled == true; }).ToArray();
				var bestByProcent = Enumerable.From(horses).OrderByDescending(function(x) { return x.marksPercentage; }).First();
				var bestByOdds = Enumerable.From(horses).OrderByDescending(function(x) { return x.odds; }).First();
			
				angular.forEach(horses, function(horse) {
					var procentValue = bestByProcent.marksPercentage / horse.marksPercentage;
					var oddsValue = horse.odds / bestByOdds.odds;
					horse.rankTal = (procentValue + oddsValue) / 2.0;
				});   	

				var score = 1;
				var horsesOrderByDesc = Enumerable.From(horses).OrderByDescending(function(x) { return x.marksPercentage; }).ToArray();
				angular.forEach(horsesOrderByDesc, function(horse) {
					horse.rankOrder = score++;
				});
		    });
		}


		function ABCDRankSettings (legs, oldSettings) {

		    if (legs == null) {
		        return null;
		    }

		    var newSettings = [];
		    var ranks = ['A', 'B', 'C', 'D'];

		    angular.forEach(ranks, function (rank) {

		        var nrOfLegsWithCurrentRank = Enumerable.From(legs).Where(function (leg) { return Enumerable.From(leg.horses).Any(function (h) { return h.rank == rank; }); }).Count();
		        var nrOfHorsesWithCurrentRank = Enumerable.From(legs).Sum(function (leg) { return Enumerable.From(leg.horses).Count(function (h) { return h.rank == rank; }); });
		        var title = rank + '-hästar (' + nrOfLegsWithCurrentRank + '/' + nrOfHorsesWithCurrentRank + ')';
		        var row = [];
		        for (var i = 0; i <= nrOfLegsWithCurrentRank; i++) {
		            row.push({'value': i, 'selected': true });
		        }
		        newSettings.push({'title': title, 'content':row, 'type':rank});
		    });

		    if (oldSettings != null) {
			    for (var row = 0; row < Math.min(oldSettings.length, newSettings.length); row++) {
			    	for (var col = 0; col < Math.min(oldSettings[row].content.length, newSettings[row].content.length); col++) {
			    		newSettings[row].content[col].selected = oldSettings[row].content[col].selected;
			    	}
			    }
		    }

		    return newSettings;
		}
	}
})();
