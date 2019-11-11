    var App = angular.module('App', ["ui.router"]);
    App.config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/');
        $stateProvider
            .state("home", {
                url: '/',                
                views: {
                    'all': {
						templateUrl: 'HTML/vehicle/show-All-Vehicle.html',
						controller: "vehicleShowAllController"
                    }
                }
			}).state("vehicles", {
				url: '/details',
                params:{obj:null},
                views: {                    
                    'vehicle': {
						templateUrl: 'HTML/vehicle/vehicle-View.html',
						controller: "vehicleController"
                    },                    
                }
                
            });
}]);
	App.filter('customSearch', function () {
	return function (input, search) {
		if (!input) return input;
		if (!search) return input;
		var expected = ('' + search).toLowerCase();
		var result = {};
		angular.forEach(input, function (value, key) {
			var actual = ('' + value).toLowerCase();
			if (actual.indexOf(expected) !== -1) {
				result[key] = value;
			}
		});
		return result;
	}
});



