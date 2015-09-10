CozyAdventure - 冒险与编程
===============================


游戏设计与计划
===============================

    ~ 表示基本已完成

1、View 展现层

    1.1 Sence 场景页面
        1.1.1 LoginScene 首页（登陆）
        1.1.2 RegistScene 注册页
        1.1.3 LoadingScene 加载过程页
        1.1.4 CampScene 个人首页（营地）
        1.1.5 冒险页面
        1.1.6 佣兵管理页面
        1.1.7 佣兵列表
        1.1.8 招募页面（抽卡）
        1.1.9 Boss战页面
        1.1.10 冒险地图选择页
        1.1.11 背包页
        1.1.12 佣兵解雇页
        1.1.13 图鉴页
        1.1.14 出战阵容调整页
        1.1.15 好友管理页

    1.2 ViewObject 可视对象
        1.2.1 佣兵卡牌
        1.2.2 物品
        1.2.3 对话

    1.3 Fight 战斗过程
        1.3.1 Farm 刷怪
        1.3.2 Boss 打boss
        1.3.3 Versus 对战
        1.3.4 Team 组队副本 

2、Game 游戏内容

    2.1 Model 实体类
        2.1.1 Player 玩家
        2.1.2 Follower 佣兵卡牌
        2.1.3 Prop 道具
        2.1.4 FollowerCollect 佣兵组
        2.1.5 PropCollect 道具集
        2.1.6 FramMap 刷怪地
        2.1.7 Package 包（包含道具、金币、经验等）

    2.2 Logic 游戏逻辑
        2.2.1 UserLogic 注册和登陆
        2.2.2 FightLogic 战斗逻辑
        2.2.3 FollowerLogic 佣兵攻击计算、升级
        2.2.4 FollowerCollectLogic 佣兵组逻辑

    2.3 Object 游戏对象
        2.3.1 PlayerObject 玩家对象
        2.3.2 BagObject 我的背包
    
    
3、Public 公共内容

    3.1 Controls 控件
        ~3.1.1 Button
        ~3.1.2 ListView

    3.2 Update 更新