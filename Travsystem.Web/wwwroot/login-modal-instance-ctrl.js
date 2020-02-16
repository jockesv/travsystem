(function() { 

	'use strict';

	angular
		.module('travLabApp')
		.controller('ModalInstanceCtrl', ModalInstanceCtrl);

	ModalInstanceCtrl.$inject = ['$scope', '$modalInstance', 'AUTH_EVENTS'];

	function ModalInstanceCtrl($scope, $modalInstance, AUTH_EVENTS) {
		$scope.$on(AUTH_EVENTS.loginSuccess, loginSuccess);

		///////////////////////////

		function loginSuccess() {
			$modalInstance.dismiss();
		}
	}
})();