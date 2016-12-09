app.controller('scCatalogCtrl', function ($scope, notifier, catalog) {
	$scope.registerCourse = function (course) {
		course.registered = true;
		catalog.updateCourse(course);
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