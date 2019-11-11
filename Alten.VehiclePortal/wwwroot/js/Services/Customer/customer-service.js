App.service("customerService", ["$http",
function ($http) {
        return {
            getcustomers: getcustomerPaging,
            addcustomer: addcustomer,          
        }
     
        function getcustomerPaging(pageSize,pageNumber,count) {
            var request = $http({
                method: "GET",
                url: "/WebAPI/api/rpc/customer/GetApplication/" + pageSize + "/" + pageNumber + "/" + count
            });
            return (request.then(
                        function (response) {                         
                            return response.data;
                        }, function (error) {
                            return error;
                        }));
        }
        function addcustomer(customer) {
            var request = $http({
                method: "POST",
                url: "/WebAPI/api/rpc/customer/Submit",
                data:customer
            });
            return (request.then(
                        function (response) {
                            return response.data;
                        }, function (error) {
                            return error;
                        }));
        }
    }]);