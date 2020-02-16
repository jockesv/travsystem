(function() {

	'use strict';

	angular
		.module('travLabApp')
		.factory('AuthInterceptor', AuthInterceptor);

	function AuthInterceptor($rootScope, $q, AUTH_EVENTS) {
		var service = {
			responseError: responseError
		};
		return service;

		//////////////////
		
		function responseError(response) { 
			$rootScope.$broadcast({
				401: AUTH_EVENTS.notAuthenticated,
				403: AUTH_EVENTS.notAuthorized,
				405: AUTH_EVENTS.methodNotAllowed,
				419: AUTH_EVENTS.sessionTimeout,
				440: AUTH_EVENTS.sessionTimeout,				
			}[response.status], response);
			return $q.reject(response);
		}
	}
})();