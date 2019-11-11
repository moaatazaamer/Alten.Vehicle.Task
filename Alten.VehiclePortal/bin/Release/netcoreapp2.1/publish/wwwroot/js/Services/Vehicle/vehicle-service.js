App.service("vehicleService", ["$http","commonClientService",
function ($http, commonClientService) {
        return {
            getvehicles: getvehiclePaging,
			listen: listen,
			pingStatus: pingStatus
	}
	function listen() {
		var request = $http({
			method: "GET",
			url: "/Vehicle/Listen/",
		});
		return (request.then(
			function (response) {
				return response;
			}, function (error) {
				return error;
			}));
	}
	function pingStatus() {
            var request = $http({
                method: "GET",
				url: "/Vehicle/Send/"
            });
		return (request.then(
			function (response) {
				return response.data;
			}, function (error) {
				return error;
			}));
        }
        function getvehiclePaging(pageSize,pageNumber,count) {
            var request = $http({
                method: "GET",
				url: "/Vehicle/GetVehicles"
            });
            return (request.then(
                        function (response) {                         
                            return response.data;
                        }, function (error) {
                            return error;
                        }));
        }
	
    }]);