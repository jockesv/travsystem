(function() {

	'use strict';

	angular
		.module('travLabApp')
		.controller('LoginController', LoginController);

	LoginController.$inject = ['$scope', '$rootScope', 'AUTH_EVENTS', 'AuthService'];

	function LoginController($scope, $rootScope, AUTH_EVENTS, AuthService) {
		
		var loginController = this;

		loginController.showAlert = false;
		loginController.credentials = {
			username: '',
			password: ''
		};
		loginController.login = login;

		/////////////////////

		function login (credentials) {
			AuthService.login(credentials).then(function (user) {
				$rootScope.$broadcast(AUTH_EVENTS.loginSuccess);
			}, function () {
				$rootScope.$broadcast(AUTH_EVENTS.loginFailed);
				loginController.showAlert = true;
			});
		}
	}

})();