app.controller('scCatalogCtrl', function ($scope, notifier, pageMethods) {
	$scope.registerCourse = function (course) {
		course.registered = true;
		pageMethods.SetCourseRegistration(course.id, course.registered);
		notifier.notify('You have registered for ' + course.name);
	}

	$scope.followInstructor = function (instructorName) {
		var found = false;
		$scope.followedInstructors.forEach(function (instructor) {
			if (instructor.name === instructorName) {
				found = true;
			}
		});
		if (!found) {
			$scope.followedInstructors.push({ name: instructorName });
			notifier.notify('You are now following ' + instructorName);
		}
	}
});