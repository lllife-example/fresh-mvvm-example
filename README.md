## FreshMVVM

เป็น MVVM framework ขนาดเล็ก ในตัวอย่างนี้มีการใช้ฟีเจอร์

- Inversion of Control (IOC) ผ่าน Constructure injection.

## โครงสร้างโปรเจค

```
├── FreshMVVMSample
│   ├── App.cs
│   ├── Models
│   │   ├── Activity.cs
│   │   ├── Comment.cs
│   │   └── User.cs
│   ├── PageModels
│   │   ├── ActivityListPageModel.cs
│   │   ├── BasePageModel.cs
│   │   └── CommentListPageModel.cs
│   ├── Pages
│   │   ├── ActivityListPage.xaml
│   │   ├── ActivityListPage.xaml.cs
│   │   ├── CommentListPage.xaml
│   │   └── CommentListPage.xaml.cs
│   ├── Properties
│   │   └── AssemblyInfo.cs
│   ├── Services
│   │   ├── ActivityService.cs
│   │   └── IActivityService.cs
│   └── Utilities
│       ├── CommandReference.cs
│       ├── Gravatar.cs
│       └── MD5.cs
└── FreshMVVMSample.iOS
    ├── AppDelegate.cs
    └── Main.cs
```

## Api ที่เกี่ยวข้อง

- FreshIOC.Container.Register, FreshBasePageModel - https://github.com/rid00z/FreshMvvm
