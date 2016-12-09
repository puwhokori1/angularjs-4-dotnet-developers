
app.controller('scScheduleCtrl', function ($scope, notifier) {
	$scope.unregisterCourse = function (course) {
		course.registered = false;
		course.$save();
		notifier.notify('You have unregistered for ' + course.name);
	}
});