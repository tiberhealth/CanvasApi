# Tiber Canvas API	

This is a .Net 5.0 wrapper library for the Canvas LMS API. The goal of this project is create a complete API wrapper for all the Canvas Modules and API calls.

**This project has just started and is not completed. The priority of the project is based on the need for internal projects. Please feel free to contribute any modules or API calls that you need. **

## Usage

The Canvas LMS API wrapper utilized the HttpClient and can be intiated in mutliple ways. The first and most common is to setup a service.

```C#
this.Services.AddHttpClient<ICanvasApiClient, CanvasApiClient>(client =>
                client.ConfigureCanvasApi(CanvasDomain, ApiKey)
            );
```



Using the GetRequiredService get the service. When using this method it is recommended that object is not directly disposed. 

```C#
var serviceProvider = this.Services.BuildServiceProvider();
var client = serviceProvider.GetRequiredService<ICanvasApiClient>();
```



The API Client can be directly initiated. Using this method, the source should properly dispose of the client object when no longer in use. 

```C#
using var client = new CanvasApiClient(CanvasDomain, ApiKey, serviceProvider);
```



## Modules Built and/or Completed

### Accounts

GetSubAccounts, List

### Assignment Groups

Create, Destroy, Edit, Get, List

### Enrollments

CourseEnrollments, SectionEnrollments, UserEnrollments

### Submissions

GetSingleCourse, GetSingleSection, ListCourse, ListCourseGroupedByStudent, ListSection, ListSectionGroupedByStudent, SubmitCourse, SubmitSection

### Users

GetProfile









