(function () {
    'use strict';

    angular.module('map')
      //.constant('GetRequestList', angular.element('#virtualDir').val().trim() + '/GetRequestList/');
      .constant('GetRequestList', 'http://localhost:64837/NewAffiliation/GetRequestList/');
    
})();
