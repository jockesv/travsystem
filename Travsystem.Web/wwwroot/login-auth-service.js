(function() {

	'use strict';

	angular
		.module('travLabApp')
		.factory('AuthService', AuthService);

	AuthService.$inject = ['$http', 'Session', '$rootScope', 'AUTH_EVENTS'];

	function AuthService($http, Session, $rootScope, AUTH_EVENTS) {

		var service = {
			authService: {},
			login: login,
			logout: logout,
			isAuthenticated: isAuthenticated,
			isAuthorized: isAuthorized
		};

		return service;

		//////////////////

		function login(credentials) {
			return $http
			.post('./api/Login', credentials)
			.then(function (res) {
				Session.create(res.data.Ticket, res.data.Name,
					res.data.Role);
				return res.data.Name;
			});
		}

		function logout() {
			return $http
			.post('./api/Logout', { Ticket: Session.ticket })
			.then(function (res) {
				Session.destroy();
				$rootScope.$broadcast(AUTH_EVENTS.logoutSuccess);
				return;
			});
		}

		function isAuthenticated() {
			return !!Session.userId;
		}

		function isAuthorized(authorizedRoles) {
			if (!angular.isArray(authorizedRoles)) {
				authorizedRoles = [authorizedRoles];
			}
			return (authService.isAuthenticated() &&
				authorizedRoles.indexOf(Session.userRole) !== -1);
		}
	}
})();	