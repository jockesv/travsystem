(function () {

    'use strict';

    angular
        .module('travLabApp')
        .factory('Coupon', Coupon);

    function Coupon () {
        var Legs = [];

        var service = {
            CountRows: CountRows,
            GenerateSingleRows: GenerateSingleRows,
            GenerateRows: GenerateRows,
            Span: Span,
            CreateMarks: CreateMarks,
            GetColorTable: GetColorTable
        };

        return service;

        /////////////////////////

        function CountRows (laps) {
            var count = 1;
            angular.forEach(laps, function(leg) {
                count *= Enumerable.From(laps).Where(function(x) { return x.rank != null; }).Count();
            });
            return count;
        }

        function GetColorTable (laps) {
            var maxRowCount = 9;

            var table = new Array(maxRowCount);
            for (var row = 0; row < maxRowCount; row++) {
                table[row] = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];
            }

            angular.forEach(laps, function(lap) {
                var i = 1;
                angular.forEach(lap, function(horse) {
                    table[i++][horse.startNumber]++;
                });
            });

            return table;
        }

        function CreateMarks (laps) {

            var result = [];

            // angular.forEach(laps, function(lap) {
            //     var marks = ['0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0'];
                
            //     angular.forEach(lap, function(horse) {
            //         marks[horse.startNumber - 1] = '1';
            //     });
            //     result.push(marks.join(""));
            // });

            angular.forEach(laps, function(lap) {
                var horses = [];    
                angular.forEach(lap, function(horse) {
                    horses.push(horse.startNumber);
                });
                result.push(horses.join(","));
            }); 

            return result;
        }

        function GenerateSingleRows (laps) {
            
            var stack = [];
            var result = [];

            this.GenerateRows(laps, 0, stack, result);
            return result;
        }

        function GenerateRows (laps, pos, stack, result) {

            if (pos < laps.length) {
                var horses = laps[pos].horses;
                angular.forEach(horses, function(horse) {
                    if (horse != null && horse.rank != null) {
                        stack.push(horse);
                        this.GenerateRows(laps, pos + 1, stack, result);
                        stack.pop();
                    }
                }, this);
            } else {
                result.push(stack.slice());
            }
        }

        function Span (min, max) {
            var span =  { 
                Max: max, 
                Min: min,
                Inside: Inside 
            };

            return span;

            function Inside (value) {
                return (value >= this.Min && value <= this.Max);
            }
        }
    }

})();
