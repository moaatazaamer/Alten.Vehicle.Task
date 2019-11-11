App.controller("vehicleController", ["$scope", "vehicleService", "commonClientService", "commonService",
	function ($scope, vehicleService, commonClientService, commonService) {
		
		$scope.init = function () {
			if (commonClientService && commonClientService.sharedParam && commonClientService.sharedParam.vehicle) {
				$scope.vehicle = angular.copy(commonClientService.sharedParam.vehicle);
			}
			if (!$scope.vehicle)
				$scope.vehicle = {};
			if (commonClientService && commonClientService.sharedParam) {
				if (commonClientService.sharedParam.isListenerServerUp == "") {
					vehicleService.listen();
					commonClientService.sharedParam.isListenerServerUp = "up";
				}
				if (commonClientService.sharedParam.isListenerServerUp == "up") {
					commonClientService.sharedParam.timeInterval = setInterval(function () {
						vehicleService.pingStatus().then(
							function (response) {
								$scope.vehicle.simStatus = response;
							})
					}, 10000);
				}
			}
			$scope.vehicle.IsHidden = false;
		}



	}]);