app.controller('scRegistrationCtrl', function ($scope, toastr, catalog, identity, followedInstructors, currentUser) {
	$scope.identity = identity;
	$scope.identity.currentUser = currentUser;
	$scope.catalog = catalog;

	$scope.followedInstructors = followedInstructors;
});