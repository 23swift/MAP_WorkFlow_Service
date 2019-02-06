(function () {
    'use strict';

    angular
        .module('map')
        .component('createComponent',{
            controller: CreateController,
            controllerAs:'vm',
            //template: '<formly-form model="vm.model" fields="vm.fields" form="vm.form"> </formly-form>',
            templateUrl: '../Views/NewAffiliation/AO/Create.html'
        
        
        
        
        });


       // .controller('CreateController', CreateController);

    /** @ngInject */
    function CreateController() {
        var vm = this;
        vm.text = 'Testing 123456';
        vm.model = {
            awesome: true
        };
        vm.fields = [
          {   className: "row",
          fieldGroup: [
              {
                  className: "col-md-4",
                  key: 'legalName',
                  type: 'input',
                  templateOptions: {
                      label: 'Legal/Business Name',
                      placeholder: 'Legal/Business Name'
                  }
              },
              {
                  className: "col-md-4",
                  key: 'Ownership',
                  type:  'select',
                  templateOptions: {
                      label: 'Ownership',
                      valueProp: 'name',
                      options: [
                             {
                                 "name": 'Corporation'
                             },
                             {
                                 "name": "Single Propreitorship"
                             }
                      ]
                  }
              },
              {
                  className: "col-md-4",
                  key: 'dtiRegDate',
                  type: 'input',
                  templateOptions: {
                      label: 'DTI Registration Date',
                      placeholder: 'Sec/DTI Registration Date'
                  }
              }
             ]
              
              
          }
     ];


        activate();


        function activate() {
            //alert('test');
            
        }

       
    }

}());