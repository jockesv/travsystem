(function() {

	'use strict';

	angular
		.module('travLabApp')
		.config(config);

	function config($httpProvider) {
		$httpProvider.interceptors.push([
		    '$injector',
		    function ($injector) {
		    	return $injector.get('AuthInterceptor');
		    }
	 	]);
	}
})();