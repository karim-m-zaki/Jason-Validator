(function () {
	'use strict'

	var app = angular.module('app');
	app.component('jsonValidator', {
		templateUrl: '/app/jsonValidatorPage/jsonValidator.html',
		controllerAs: 'vm',
		controller: ['$resource', 'appSettings', '$scope', controller]
	});
	function controller($resource, appSettings, $scope) {
		var vm = this;
		vm.jsondata = "";
		vm.validate = function (data) {
			debugger
			if (data.jsondata == "") {
				$('#endMessage').modal('show');
				vm.ErrMassge = "Please enter Json Data to be Validated";
				vm.messageSuc = false;
				vm.messageErr = true;
			}
			else {
				$resource(appSettings.serverPath + 'jsonvalidator')
					.save(data).$promise.then(onSuccess, onError);
				function onSuccess(response) {
					if (response.item1 == true) {
						$('#endMessage').modal('show');
						vm.SuccessMess = response.item2;
						vm.messageSuc = true;
						vm.messageErr = false;
					}
					else {
						$('#endMessage').modal('show');
						vm.ErrMassge = response.item2;
						vm.messageSuc = false;
						vm.messageErr = true;
					}
				};
				function onError(response) {
					alert(response.data.message);
				}
			}
		}
	}
}());