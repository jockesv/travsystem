(function(){
	'use strict';

		angular
			.module('travLabApp')
			.factory('dataservice', dataservice);

		dataservice.$inject = ['$http', 'Session'];

		function dataservice($http, Session) {

			var service = {
				loadRaceDays: loadRaceDays,
				loadRace: loadRace,
				getBetFile: getBetFile
			};

			return service;

			/////////////////////

			function loadRaceDays(baseUrl) {
				return $http.post(baseUrl + '/GetRaceDays', { Ticket: Session.ticket })
					.then(loadRaceDaysSuccess)
					.catch(loadRaceDaysError);

				function loadRaceDaysSuccess(response) {
					return response.data;
				}

				function loadRaceDaysError(error) {
					console.error(error);
				}
			}

			function loadRace(baseUrl, race) {
				return $http.post(baseUrl + '/GetRace', { 
						Race: race, 
						Ticket: Session.ticket 
					})
					.then(loadRaceSuccess)
					.catch(loadRaceError);

				function loadRaceSuccess(response) {
					return response.data;					          
				}

				function loadRaceError(error) {
					console.error(error);
					//console.error(data);
				}
			}

			function getBetFile(baseUrl, raceDay, rows, systemSize, reducedSize) {
		    	return $http.post(baseUrl + '/GetBettingFile', {
		      		Ticket: Session.ticket,
		      		RaceDay: raceDay,
		      		Rows: rows,
		      		SystemSize: systemSize,
		      		ReducedSize: reducedSize,
		      		Filename: "filnamn"
		    	})
		    	.then(getFileSuccess) 
		    	.catch(getBetFileError);

		    	function getFileSuccess(response) {
		      		return response.data;
		    	}

		    	function getBetFileError(error) {
		      		console.error(error);
		    	}
		  	}
		}
})();