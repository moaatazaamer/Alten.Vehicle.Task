App.controller("customerController", ["$scope", "customerService", "customerClientService", "commonService",
	function ($scope, customerService, customerClientService, commonService) {


		$scope.init = function () {
			if (customerClientService && customerClientService.sharedParam) {
				$scope.customer = angular.copy(customerClientService.sharedParam);
			}
			customerClientService.sharedParam = {};
			if (!$scope.customer)
				$scope.customer = {};

			$scope.customer.IsHidden = false;
		}

		$scope.addcustomer = function ($event) {
			if ($event)
				event.preventDefault();
			$scope.customer.IsHidden = true;
			if ($scope.customer && $scope.customer.Name)
				customerService.addcustomer($scope.customer).then(
					function (response) {
						if (response && response.IsSuccessded) {
							$scope.customer = response.Data;
						}

					});
		}



	}]);