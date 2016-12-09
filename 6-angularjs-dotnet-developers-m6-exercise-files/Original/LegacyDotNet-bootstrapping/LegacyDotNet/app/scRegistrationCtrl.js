app.controller('scRegistrationCtrl', function ($scope, toastr, catalog, identity, followedInstructors) {
	$scope.identity = identity;
	$scope.catalog = catalog;

	$scope.followedInstructors = followedInstructors;
});