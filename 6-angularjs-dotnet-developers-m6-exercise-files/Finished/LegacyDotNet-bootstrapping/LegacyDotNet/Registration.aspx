<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/AngularScripts.master" AutoEventWireup="true"
    CodeBehind="Registration.aspx.cs" Inherits="LegacyDotNet.Registration" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<script type="text/javascript">
		var currentUser = {id:<%=CurrentUser.Id %>, name: '<%=CurrentUser.Name %>'}
		
		<asp:literal runat="server" ID="litFollowedInstructors" />

	</script>
	<div class="container" ng-controller="scRegistrationCtrl" ng-app="app">
		<div class="well"><div class="container"><h2>Registration - {{identity.currentUser.name}}</h2></div></div>
		<div class="row">
			<div class="col-md-8">
				<div ng-controller="scCatalogCtrl">
					<h3>Available Courses</h3>
					<input type="search" class="search-query" placeholder="Search" ng-model="searchText" />
					<table class="table table-striped table-hover table-condensed">
						<thead>
						<tr>
							<th>Name</th>
							<th>Credits</th>
							<th>Instructor</th>
							<th>&nbsp;</th>
						</tr>
						</thead>

						<tr ng-repeat="course in catalog | filter:{registered:false} | filter:searchText" >
							<td>
								{{course.name}}
							</td>
							<td>
								{{course.credits}}
							</td>
							<td>
								<a href="" ng-click="followInstructor(course.instructorName)">{{course.instructorName}}</a>
							</td>
							<td>
								<button class="btn btn-primary btn-xs" ng-click="registerCourse(course)">Select</button>
							</td>
						</tr>
					</table>
				</div>
			</div>
			<div class="col-md-4">
				<div class="well sidebar-nav" ng-controller="scScheduleCtrl">
					<h4>Your Schedule</h4>
					<div class="row" ng-repeat="course in catalog | filter:{registered:true}">
						<div class="col-md-12">

							<button class="btn btn-default btn-xs" ng-click="unregisterCourse(course)">X</button> {{course.name}} - {{course.credits}} credits
						</div>
					</div>

				</div>
				<div class="well sidebar-nav" ng-controller="scFollowedInstructorsCtrl">
					<h4>Instructors ({{followedInstructors.length}} followed)</h4>
					<div class="row" ng-repeat="instructor in followedInstructors">
						<div class="col-md-6">{{instructor.name}}</div>
						<div class="col-md-6">
							<div class="instructor-follow-button">
								<button ng-click="unFollowInstructor(instructor)" class="btn btn-info btn-xs">Unfollow</button>
							</div>
						</div>
					</div>
				</div>

			</div>
		</div>

	</div>
</asp:Content>
