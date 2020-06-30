# NETCore-Dapper

Demo中使用两种方式实现了Dapper

一种是自定义Helper类，构造单例模式实现

另一种方式是依赖注入到StartUp.cs，支持多种数据库（DbFactory），数据库连接字符串支持热更新