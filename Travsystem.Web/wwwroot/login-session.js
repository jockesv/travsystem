	(function() {

		'use strict';

		angular
			.module('travLabApp')
			.service('Session', Session);

		function Session() {

			var vm = this;
			vm.create = create;	
			vm.destroy = destroy;

			///////////////////

			function create(ticket, name, role) {
				this.ticket = ticket;
				this.name = name;
				this.role = role;
			}

			function destroy() {
				this.ticket = null;
				this.name = null;
				this.role = null;
			}

			return this;
		}
	})();