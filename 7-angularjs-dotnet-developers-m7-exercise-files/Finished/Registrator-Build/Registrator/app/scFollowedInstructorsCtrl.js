angular.module('app').controller('scFollowedInstructorsCtrl', function ($scope, notifier) {

	$scope.unFollowInstructor = function (instructor) {
		$scope.followedInstructors.splice($scope.followedInstructors.indexOf(instructor), 1);
		notifier.notify('You have unfollowed ' + instructor.name);
	}
});