
app.controller('scScheduleCtrl', function ($scope, notifier, pageMethods) {
	$scope.unregisterCourse = function (course) {
		course.registered = false;
		pageMethods.SetCourseRegistration(course.id, course.registered);
		notifier.notify('You have unregistered for ' + course.name);
	}
});