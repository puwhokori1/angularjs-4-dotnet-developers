angular.module('app').controller('scRegistrationCtrl', function ($scope, toastr, scCatalog, scFollowedInstructors) {
	$scope.catalog = scCatalog;
	$scope.followedInstructors = scFollowedInstructors;
});