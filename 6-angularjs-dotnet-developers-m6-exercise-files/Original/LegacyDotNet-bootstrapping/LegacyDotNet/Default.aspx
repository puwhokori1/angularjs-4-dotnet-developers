<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="LegacyDotNet._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<div class="container">
		<div class="well"><div class="container"><h2>The Registrator</h2></div></div>
		<div class="row">
			<div class="col-md-8">
				<div>
					<h3>Welcome!</h3>
					<p>You are on the Registrator. We offer classes on everything from Biology to Intermediate Biology. Class times are 5 days
					a week from 2am until 6am, to make sure that you have no schedule conflicts. 99% of our graduates are wokring in the food services industry, 
					making an average of 20% above minimum wage. Our highly skilled and qualified professors have each seen several movies relating to their coursework
					and are considered experts in their respective fields by their spouses and children. Our instructors each pass a rigorous take home exam to demonstrate
					their skill and expertise. Tutoring is available free of charge through our offshore tutoring email service to give you the best chance
					to pass your classes and graduate the head of your class.

					</p>
				</div>
			</div>
			<div class="col-md-4">
				<div class="well sidebar-nav" ng-controller="scScheduleCtrl">
					<h4>Our Benefits</h4>
					<p>Our classes are some of the best in the nation. Each class you register for is sponsored by a tribe of
					Alaskan penguin handlers.</p>

				</div>
				

			</div>
		</div>

	</div>
</asp:Content>
