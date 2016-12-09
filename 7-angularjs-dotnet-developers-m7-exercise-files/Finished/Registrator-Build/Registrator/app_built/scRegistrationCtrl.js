angular.module('app').controller('scRegistrationCtrl', [
  '$scope',
  'toastr',
  'scCatalog',
  'scFollowedInstructors',
  function ($scope, toastr, scCatalog, scFollowedInstructors) {
    $scope.catalog = scCatalog;
    $scope.followedInstructors = scFollowedInstructors;
  }
]);