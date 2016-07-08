#Git 常用命令行

  [TOC]
  
##初始化
###配置使用git仓库的人员姓名  
git config --global user.name "Your Name Comes Here"  (改引号里面的)
  
###配置使用git仓库的人员email  
git config --global user.email you@yourdomain.example.com  

##取得Git仓库

###初始化一个版本仓库  
git init  
  
###Clone远程版本库  
git clone git@xbc.me:wordpress.git  
  
###添加远程版本库origin 
git remote add origin git@xbc.me:wordpress.git  
**语法为 git remote add [shortname] [url]** 
  
###查看远程仓库  
git remote -v  
##基本的分支管理
###创建一个分支  
git branch iss53  
  
###切换工作目录到iss53  
git chekcout iss53  
  
###将上面的命令合在一起，创建iss53分支并切换到iss53  
git chekcout –b iss53  
  
###合并iss53分支，当前工作目录为master  
git merge iss53  
  
###合并完成后，没有出现冲突，删除iss53分支  
git branch –d iss53  
  
###拉去远程仓库的数据，语法为 git fetch [remote-name]  
git fetch  
  
###fetch 会拉去最新的远程仓库数据，但不会自动到当前目录下，要自动合并  
git pull  
  
###查看远程仓库的信息  
git remote show origin  
##Git远程分支管理
git pull                         # 抓取远程仓库所有分支更新并合并到本地  
git pull --no-ff                 # 抓取远程仓库所有分支更新并合并到本地，不要快进合并  
git fetch origin                 # 抓取远程仓库更新  
git merge origin/master          # 将远程主分支合并到本地当前分支  
git co --track origin/branch     # 跟踪某个远程分支创建相应的本地分支  
git co -b <local_branch> origin/<remote_branch>  # 基于远程分支创建本地分支，功能同上  
   
git push                         # push所有分支  
git push origin master           # 将本地主分支推到远程主分支  
git push -u origin master        # 将本地主分支推到远程(如无远程主分支则创建，用于初始化远程仓库)  
git push origin <local_branch>   # 创建远程分支， origin是远程仓库名  
git push origin <local_branch>:<remote_branch>  # 创建远程分支  
git push origin :<remote_branch>  #先删除本地分支(git br -d <branch>)，然后再push删除远程分支