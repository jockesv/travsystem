(function() {

	'use strict';

	angular
		.module('travLabApp')
		.factory('ABCDReduction', ABCDReduction);

	function ABCDReduction() {

		var service = {
			Reduce: Reduce
		};

		return service;

		//////////////////////

		function Reduce (rank_a, rank_b, rank_c, rank_d, rows) {

		return Enumerable.From(rows)
			.Where(function(row) { 
				return rank_a.Inside(Enumerable.From(row).Where(function(x) { 
					return x.rank == "A";
				}).Count()); 
			})
			.Where(function(row) { 
				return rank_b.Inside(Enumerable.From(row).Where(function(x) { 
					return x.rank == "B";
				}).Count()); 
			})
			.Where(function(row) { 
				return rank_c.Inside(Enumerable.From(row).Where(function(x) { 
					return x.rank == "C";
				}).Count()); 
			})
			.Where(function(row) { 
				return rank_d.Inside(Enumerable.From(row).Where(function(x) { 
					return x.rank == "D";
				}).Count()); 
			}).ToArray();
		}
	}
})();


