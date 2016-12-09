app.controller('scRegistrationCtrl', function ($scope, toastr, catalog, identity, followedInstructors, pageMethods) {
	$scope.identity = identity;
	pageMethods.GetCurrentUser(function(user) {
		$scope.identity.currentUser = { id: user.Id, name: user.Name };
		$scope.$apply();
	});
	$scope.catalog = catalog;
	$scope.followedInstructors = followedInstructors;
});