#Code First(MySql)
网上有很多关于用EntityFrame来连接Mysql数据库的教程，可是很多并不靠谱，转载的太多了。找了很久，总算是配置好了，现在分享一下。

##一，安装：
(百度网盘)
    1、开发环境： VS2015与EF6
    2、Mysql数据库为：Mysql Server 6.0
    3、安装：Mysql for Visual Studio 1.1.1
            下载位置：https://cdn.mysql.com/Downloads/MySQLInstaller/mysql-visualstudio-plugin-1.1.1.msi
    4、安装 Mysql Connector/Net 6.8.3 GA
            下载位置：http://dev.mysql.com/downloads/connector/net/
##二，引用dll：
在 - 工具 - 库程序包管理器 - 程序包管理器控制台 这里 默认项目， 在PM>后 输入 
Install-Package EntityFramework 
Install-Package MySql.Data.Entity
##三，添加 ConnectionString节点： 
该节点不能添加在配置文件的开头。

    <connectionStrings>
    <add name="MyContext" connectionString="Data Source=localhost;port=3306;Initial Catalog=数据库名称;user id=Mysql的登录用户名;password=Mysql server密码;" providerName="MySql.Data.MySqlClient"/>
    </connectionStrings>
#四，注意
最好在继承DbContext类的前面加上[DbConfigurationType(typeof(MySqlEFConfiguration))]这样可以少很多的问题，有时候不加也可以！最好加上。（EF版本6.8以上都要加）

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
        public class MyContext : DbContext
        : base("name=MyContext")//web.config中connectionstring的名字（这样可以创建多个连接）

#参见：
[EntityFramework 6.0< Code First > 连接 Mysql数据库](http://blog.csdn.net/kmguo/article/details/19650299)

[在EntityFramework connector 6.8.* 版本之后需要在Contxt文件里面添加一句代码。](http://nowhereman.cn/mysql-load-mysql-data-entity-ef6-version6-9-4-0-cultureneutral/)

[在MVC中使用CodeFirst](http://www.cnblogs.com/Wayou/archive/2012/09/20/EF_CodeFirst.html)

#深入学习
[使用ADO.NET Entity Framework 4.1进行Code First模式的开发](http://blog.sina.com.cn/s/blog_4c81e6230100qdwz.html)

[mysql服务启动不了 不能完全卸载 解决办法 ](http://www.cnblogs.com/jiangyao/archive/2010/05/19/1739048.html)

[EF Code First增删改查](http://www.cnblogs.com/libingql/archive/2013/01/29/2881988.html)

[精进不休 .NET 4.0 (9) - ADO.NET Entity Framework 4.1 之 Code First ](http://www.cnblogs.com/webabcd/archive/2011/05/23/2054002.html)