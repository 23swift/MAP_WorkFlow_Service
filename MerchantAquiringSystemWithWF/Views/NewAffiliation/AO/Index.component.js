(function () {
    'use strict';
    angular
        .module('map')
        .component('indexComponent', {
            controller: IndexController,
            controllerAs: 'vm',
            //template: '<formly-form model="vm.model" fields="vm.fields" form="vm.form"> </formly-form>',
            templateUrl: '../Views/NewAffiliation/AO/Index.html'




        });
    IndexController.$inject = ['newAffiliationService'];
    function IndexController(newAffiliationService) {
        var vm = this;
        vm.requestList = [];

        function getRequestList() {
            newAffiliationService.getRequestList().then(function (response) {
                vm.requestList = angular.copy(response.data);
               // alert(angular.toJson(vm.requestList));

            });
        }
       




        activate();


        function activate() {
            getRequestList();

        }
    }

    

}());