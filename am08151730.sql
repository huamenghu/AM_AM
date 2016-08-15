/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50625
Source Host           : localhost:3306
Source Database       : am

Target Server Type    : MYSQL
Target Server Version : 50625
File Encoding         : 65001

Date: 2016-08-15 17:30:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for ad
-- ----------------------------
DROP TABLE IF EXISTS `ad`;
CREATE TABLE `ad` (
  `adid` varchar(36) NOT NULL,
  `adimgurl` varchar(255) DEFAULT NULL,
  `F1` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`adid`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of ad
-- ----------------------------
INSERT INTO `ad` VALUES ('03e13062-63e5-48e3-949c-bdad00ee1ffd', '/fileupload/ad/Original/b06903c12cc24a3e9784584bf249554f.png', '1');
INSERT INTO `ad` VALUES ('a26aed55-6a82-4726-873c-88a5f9897b79', '/fileupload/ad/Original/4bebbb3562b94dea97906ffd3532f707.png', '2');
INSERT INTO `ad` VALUES ('f8bb5ee0-39f0-4512-8a3e-3882072e6e3b', '/fileupload/ad/Original/b24155c3cd2843358568b09ae26ceba6.png', '3');

-- ----------------------------
-- Table structure for addr
-- ----------------------------
DROP TABLE IF EXISTS `addr`;
CREATE TABLE `addr` (
  `addrid` varchar(36) COLLATE utf8_bin NOT NULL,
  `userid` varchar(36) COLLATE utf8_bin NOT NULL,
  `addrname` varchar(50) COLLATE utf8_bin NOT NULL,
  `addrphone` varchar(50) COLLATE utf8_bin NOT NULL,
  `addraddr` varchar(255) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`addrid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of addr
-- ----------------------------
INSERT INTO `addr` VALUES ('19193972-e806-4cfb-bf1c-38bb50ccd7ec', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '山西太原', '15234022725', '山西省太原市');
INSERT INTO `addr` VALUES ('30d949c0-b167-44c4-ab53-c16d23b9fe31', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '1', '1', 'sdfsafsda');
INSERT INTO `addr` VALUES ('39de345c-a133-4fe9-8129-8ca8e548ae6d', 'bbacc27f-7d86-46a5-89e3-4a0f3020453e', '没多大那就睡觉', '15523231512', '包步行街小鸡小鸡想见你');
INSERT INTO `addr` VALUES ('3c949b57-1b83-40a9-a6b7-5d96f5c72ad8', '1bbd62df-d47a-4d65-99ed-41f16181684a', 'liu', '15575757575', 'fkslalfjlkj');
INSERT INTO `addr` VALUES ('3eb768a3-85fe-4565-af11-850b1b1b6886', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '1', '1', 'mingxing');
INSERT INTO `addr` VALUES ('43182252-5346-4eeb-b65f-390473682b52', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '钱', '15052218101', '无锡市锡山区芙蓉中一路121号');
INSERT INTO `addr` VALUES ('4c823cf7-bea8-409c-b153-0325f056f8ad', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', 's', 's', 's');
INSERT INTO `addr` VALUES ('4f680591-87d1-43d1-99f2-9355004b2c03', '1f46314c-2fe9-4272-963b-4f2330c2daee', '反反复复', '458962455', '豆腐坊GD SS QQ');
INSERT INTO `addr` VALUES ('51b20579-b250-4b8c-a502-69991ab43cbd', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '空军', '133455555556', '啦啊啊啊啊啊');
INSERT INTO `addr` VALUES ('5a03f1cd-03fa-4a5a-8ec1-409df8ebdb80', 'd9ad4789-6e5c-4703-b5b8-f6afcce57f81', 'hxbdhh ', 'dhhhshh ', 'bdbdhdjshsh ');
INSERT INTO `addr` VALUES ('614ed591-ae1d-446d-8ad7-8893a77cb639', '6ad19cc5-14a0-4743-ab88-4b3c10455703', '李 阿', '15576767676', '中国北京');
INSERT INTO `addr` VALUES ('61dc24fa-583f-40d5-802f-a87173d930e3', 'c964d548-4908-4fc6-a078-75a3d00f3644', '哈哈哈哈', '44444444444', '了了了了了了了了');
INSERT INTO `addr` VALUES ('670e02ac-9bf4-4f7d-8024-d11d282d025d', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', 'sa', '543253', 'fsd');
INSERT INTO `addr` VALUES ('68ea88bc-03bc-45e6-83cc-d60cafa366d2', 'e38f126c-0051-4d93-b246-05d6297a75b5', '??', '1557555', '234');
INSERT INTO `addr` VALUES ('7fb0e7b9-42e9-464f-93c2-039c06160ad2', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '111', '1111', '1111');
INSERT INTO `addr` VALUES ('7fb0e7b9-42e9-464f-93c2-039c06160ad3', '7fb0e7b9-42e9-464f-93c2-039c06160ad2', '222', '222', '222');
INSERT INTO `addr` VALUES ('8576df11-575e-4355-a7ce-fa008bc048ad', '60ed6597-1993-47a3-8360-4096993799d6', '曹', '16767676767', '冯绍峰建设');
INSERT INTO `addr` VALUES ('89384416-0de8-45fe-8ae6-d63f9f3e6ea5', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '1', '1', '1');
INSERT INTO `addr` VALUES ('91324528-6dfc-491e-a804-96d7e84a04ab', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '比较馍馍', '13453125454', '北京大学');
INSERT INTO `addr` VALUES ('9896a57e-965c-4a74-8f22-aad276f2b8f2', '577c8982-c23b-405a-b204-ee12bdde7c95', '八里街', '13726982180', '1555558');
INSERT INTO `addr` VALUES ('a520fe84-8963-40fd-8bef-bab537991a03', 'e38f126c-0051-4d93-b246-05d6297a75b5', '????', '12323', '2132');
INSERT INTO `addr` VALUES ('a9997f9e-7f05-43cb-95fd-336742d64ea7', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '1', '1', '1');
INSERT INTO `addr` VALUES ('ab92627a-022f-48d0-88ed-150dcb846328', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '投胎', '2455；ffq', '非要得到的人');
INSERT INTO `addr` VALUES ('af582485-e4ae-4787-b646-6846bd72b7f8', '60ed6597-1993-47a3-8360-4096993799d6', '李 第八', '15565656556', '各行各界');
INSERT INTO `addr` VALUES ('b75a65a7-67c8-485c-8c4d-4af54433fb40', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', 'ds', 'ds', 'da');
INSERT INTO `addr` VALUES ('b91287b6-3130-4baa-8c57-81e5cc2651e4', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '1', '1', '1');
INSERT INTO `addr` VALUES ('ca50392d-3b45-489d-ada4-57859cfcabcc', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '哈哈', '17703417342', '上海市');
INSERT INTO `addr` VALUES ('cc5c315b-0bc5-4780-93c6-2bfc8f6bb758', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', '1', '1', '1');
INSERT INTO `addr` VALUES ('d3297e93-22c8-4404-ae34-6ceace5ace34', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '来来来', '13726982180', '看记录');
INSERT INTO `addr` VALUES ('e5c72c98-fbfd-4414-8990-e8ee6818af7c', 'ead5c475-6fbc-44f1-b4e7-ef8abf1aa3fe', 'wwwww', '4444', 'fgh&ddgjswfh');
INSERT INTO `addr` VALUES ('e5e25e07-a789-406b-8b47-b644c9ae86da', '366e9a99-8147-4a33-9058-a58687890c09', 'ldq', '15554545454', 'address');
INSERT INTO `addr` VALUES ('e79209f8-b988-413e-b9e0-8261b966287b', 'e5f37957-8397-478b-b917-d60dd07804fe', '\"momo\"', '\"123456\"', '\"??\"');
INSERT INTO `addr` VALUES ('f7fbdf93-1ccb-4c14-a82a-cee7c69e30a8', 'e38f126c-0051-4d93-b246-05d6297a75b5', '???2', '12323', '3123');
INSERT INTO `addr` VALUES ('fdf9d972-4e94-4f7a-a972-13d77a1b2756', 'e38f126c-0051-4d93-b246-05d6297a75b5', '?????', '12321321', '???????');

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin` (
  `GUID` char(36) COLLATE utf8_bin NOT NULL,
  `UserName` varchar(50) COLLATE utf8_bin NOT NULL,
  `Password` varchar(250) COLLATE utf8_bin NOT NULL,
  `Type` varchar(50) COLLATE utf8_bin NOT NULL,
  `Remark` varchar(250) COLLATE utf8_bin DEFAULT NULL,
  `Department` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`GUID`),
  KEY `FK_Reference_5` (`Department`),
  CONSTRAINT `FK_Reference_5` FOREIGN KEY (`Department`) REFERENCES `department` (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('21ff52fc-ec60-454e-997a-a66ec6ea3148', 'admin', '1FA56ED12CEA0BAC', 'Admin', '', null);
INSERT INTO `admin` VALUES ('a06e439c-6aa0-4d07-b4b2-7a73856c92c0', '11', '11', 'admin', '11', null);
INSERT INTO `admin` VALUES ('e630908f-0909-42d4-8d0d-0c0638a03bfd', 'user', '6E8EE42DF93E4732', 'User', '', null);

-- ----------------------------
-- Table structure for alipay
-- ----------------------------
DROP TABLE IF EXISTS `alipay`;
CREATE TABLE `alipay` (
  `guid` varchar(36) COLLATE utf8_bin NOT NULL,
  `partner` varchar(200) COLLATE utf8_bin DEFAULT NULL COMMENT '支付宝合作身份者ID',
  `private_key` varchar(2000) COLLATE utf8_bin DEFAULT NULL COMMENT '支付宝商户的私钥',
  `ali_publick_key` varchar(1000) COLLATE utf8_bin DEFAULT NULL COMMENT '支付宝公钥',
  `notify_url` varchar(500) COLLATE utf8_bin DEFAULT NULL COMMENT '支付成功回调地址',
  `seller` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of alipay
-- ----------------------------
INSERT INTO `alipay` VALUES ('1', '2088021522039312', 'MIICXQIBAAKBgQC19MXxcRpAvwlRleC+Qp7s3yoJAhiEV8X7eaGs6U3cJbBKI/e4ZyrL9ilUHa3q6alAuXk5TIf0FyMNOrQS/biZEI7UpBcKoqbSeKFEG4749SI9/FNj1+YvbSYL/Zd7QxNSzpP1NfBBkmZ4/v1nzzPn82/HpW8RX/uuFyKWuwiXdQIDAQABAoGAPLKIjYAzR8Hyc9rRe+ZxaYcQWKzwTMWS786lVi8FoBiadEEHU+Zmal+Vbc/wwlpr8YFtpOWYvJ4zPSiGBYfJ2gUxbxSYkmCyY8z0n0biADInd89CYY6CHnkB46kkZdehs5DZFb4yML4xZBcBcPmb8s7pXuzRZCvJk8RQkD8QN0ECQQDpfvctqNCRZRuwrxWm2G7fI5lvQFiY1sBp1+q/ZiAYw+RNnZ5FkjDloWEnygMRzKwAjgLUB34ISNw4ZuqVHkNpAkEAx34rGS17yp01ay0IQ6hJoh5IeuAGw0SVsF895YCAwOFkZ0lm8WYQS7GmyhdcRefNldtmjT/wHgrWBD9avu8OLQJAK+Po1JVZ9yqZROH0YPNoC9umOMpQnRIpAvxKLQYmXGFeJdTN7mfndxKZr6ACabMeVdBb6b0qzKXdd2CpEbSpmQJBAKLwEhOGas2aib74EP/xu/KF+X0i7WMf6YMcx1lkE8V2UqNp+ILCchzhBPGbEuql4ey8Po6v4lcnUpY1iNDaQCECQQCYbe9UKLl0gbia68/ZRybt+s0RFVDpubu4Vf4SlvuKaPhDiVhyWAUUoGTZvh5o+7N/VbwCH//JkC9DZWr1KHrp', 'MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC19MXxcRpAvwlRleC+Qp7s3yoJAhiEV8X7eaGs6U3cJbBKI/e4ZyrL9ilUHa3q6alAuXk5TIf0FyMNOrQS/biZEI7UpBcKoqbSeKFEG4749SI9/FNj1+YvbSYL/Zd7QxNSzpP1NfBBkmZ4/v1nzzPn82/HpW8RX/uuFyKWuwiXdQIDAQAB', 'http://s-208411.abc188.com/alipay/notify_url', 'hatm123@sina.com');

-- ----------------------------
-- Table structure for app
-- ----------------------------
DROP TABLE IF EXISTS `app`;
CREATE TABLE `app` (
  `appid` varchar(36) COLLATE utf8_bin NOT NULL,
  `content` varchar(2000) COLLATE utf8_bin NOT NULL,
  `sort` int(11) NOT NULL,
  `keyword` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`appid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of app
-- ----------------------------
INSERT INTO `app` VALUES ('00000000-0000-0000-0000-000000000001', '无忧售后，积分规则内容', '0', null, '积分规则');
INSERT INTO `app` VALUES ('00000000-0000-0000-0000-000000000002', '无忧售后，联系我们内容', '0', null, '联系我们');
INSERT INTO `app` VALUES ('00000000-0000-0000-0000-000000000003', '无忧售后，关于我们信息', '0', null, '关于我们');

-- ----------------------------
-- Table structure for applicationinfo
-- ----------------------------
DROP TABLE IF EXISTS `applicationinfo`;
CREATE TABLE `applicationinfo` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `applicompanyname` varchar(100) DEFAULT NULL,
  `applicompanyaddr` varchar(100) DEFAULT NULL,
  `applibusinessregistnumber` varchar(100) DEFAULT NULL,
  `appliorganizationcode` varchar(100) DEFAULT NULL,
  `appliregistercapital` varchar(100) DEFAULT NULL,
  `appliemployer` varchar(100) DEFAULT NULL,
  `appliregistrationdate` datetime DEFAULT NULL,
  `applieconomytype` varchar(100) DEFAULT NULL,
  `appliqualificationtypeid` varchar(100) DEFAULT NULL,
  `applilinkname` varchar(100) DEFAULT NULL,
  `applilinktel` varchar(100) DEFAULT NULL,
  `appliemail` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of applicationinfo
-- ----------------------------
INSERT INTO `applicationinfo` VALUES ('04bf916d-bc7f-4dc7-a2a6-501d3756749f', 'admin', '1gdsfgsdfg', '1', '1', '423423', '', '', null, '', '00001', '2', '111111111111111111111111111111', '11111111111111111111111', '已处理', '', '2015-09-18 17:30:02', 'admin', null);
INSERT INTO `applicationinfo` VALUES ('54ab16d7-09e9-4d1b-8d9d-9333822545fb', '577c8982-c23b-405a-b204-ee12bdde7c95', 'ggg', 'ggg', 'fff', 'ffg', '55', 'fgg2015-', '2015-01-02 00:00:00', 'fgg', '吊篮制造企业生产资质', 'gvv', '123456', 'fff', '未处理', '\0', null, null, null);
INSERT INTO `applicationinfo` VALUES ('63d510ca-0f92-4675-9ed7-4180669e086e', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '太阳', '规划环境', '43367988', '245688900', '5000', '风格hu', '2015-06-04 00:00:00', '有限责任公司', 'd80fb66f-b4e0-4915-a15f-ebcab7b8cd75', '太阳', '124578800', '467@', '未处理', '\0', null, null, null);
INSERT INTO `applicationinfo` VALUES ('8d817c7d-7590-4ea6-8d80-a669477b053f', '577c8982-c23b-405a-b204-ee12bdde7c95', 'ggg', 'ggg', 'ggg', 'ggg', '55', 'fvg', '2015-05-04 00:00:00', 'g', '46927769-3473-4134-b675-cf26061dab34', 'ggg', 'tgg', 'ffff', '未处理', '\0', null, null, null);
INSERT INTO `applicationinfo` VALUES ('a23f0457-b182-4928-b26b-0578b439a3eb', 'admin', '1', '2', '3', '4', '5', '6', '2015-09-09 00:00:00', '71', '0000100001', '8', '9', '10', '未处理', '\0', '2015-09-10 01:25:01', 'admin', null);
INSERT INTO `applicationinfo` VALUES ('ea555dfd-ab77-45d3-b660-55faaaae5fc3', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '资H好', '该公司公司', '该公司', '得到很好', '30', '大概是个帅哥问我', '2015-10-21 00:00:00', '很好', 'd80fb66f-b4e0-4915-a15f-ebcab7b8cd75', '共商国是个', '13455661616', '嘎嘎哈哈', '未处理', '\0', null, null, null);
INSERT INTO `applicationinfo` VALUES ('f5799d57-8ec9-486f-9345-2e8158c87a28', '577c8982-c23b-405a-b204-ee12bdde7c95', 'ggg', 'ggg', 'fff', 'ffg', '55', 'fgg2015-', '2015-01-02 00:00:00', 'fgg', '吊篮制造企业生产资质', 'gvv', '123456', 'fff', '未处理', '\0', null, null, null);
INSERT INTO `applicationinfo` VALUES ('f6dee27f-97b2-4571-825d-74492ac51c1f', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '白天', '阿莫无聊', '3288567755599', '258809654', '5000', '看哦页', '2015-05-12 00:00:00', '有限责任', '吊篮租赁企业安装资质', '安慰', '1288693', 'LadyGaga', '未处理', '\0', null, null, null);

-- ----------------------------
-- Table structure for appraisalaccident
-- ----------------------------
DROP TABLE IF EXISTS `appraisalaccident`;
CREATE TABLE `appraisalaccident` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `accidentcompanyname` varchar(100) DEFAULT NULL,
  `accidentcompanyaddr` varchar(100) DEFAULT NULL,
  `accidentnenginename` varchar(100) DEFAULT NULL,
  `accidentnenginenaddr` varchar(100) DEFAULT NULL,
  `accidentgoodsname` varchar(100) DEFAULT NULL,
  `accidentgoodstype` varchar(100) DEFAULT NULL,
  `accidenttype` varchar(100) DEFAULT NULL,
  `accidentdescription` varchar(100) DEFAULT NULL,
  `accidentoccurrencetime` datetime DEFAULT NULL,
  `accidentlinkname` varchar(100) DEFAULT NULL,
  `accidentlinktel` varchar(100) DEFAULT NULL,
  `accidentemail` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of appraisalaccident
-- ----------------------------
INSERT INTO `appraisalaccident` VALUES ('c236d6f9-4348-4a86-bed7-db54cdbdd604', '577c8982-c23b-405a-b204-ee12bdde7c95', 'v', 'g', 'h', 'g', 'h', 'g', '3333', 'g', '2015-05-08 00:00:00', '4444', '5555', '', '已处理', '\0', null, null, null);
INSERT INTO `appraisalaccident` VALUES ('c248a7d2-5fb4-477a-a25f-942fd851353f', '1f46314c-2fe9-4272-963b-4f2330c2daee', '如果超级棒v', '都有人地方v', '额太丰富胡', '额衣服v结婚', '容易扶摇皇后', '容易发过火vv', '鉴定,', '日月光华火腿肠v几', '2015-07-09 00:00:00', null, null, null, '未处理', '\0', null, null, null);

-- ----------------------------
-- Table structure for appraisalapplication
-- ----------------------------
DROP TABLE IF EXISTS `appraisalapplication`;
CREATE TABLE `appraisalapplication` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `appraisalcompanyname` varchar(100) DEFAULT NULL,
  `appraisalcompanyaddr` varchar(100) DEFAULT NULL,
  `appraisalgoodsname` varchar(100) DEFAULT NULL,
  `appraisalgoodstype` varchar(100) DEFAULT NULL,
  `appraisalmanufacturer` varchar(100) DEFAULT NULL,
  `appraisaloutfactorydate` varchar(100) DEFAULT NULL,
  `appraisalgoodssummary` varchar(100) DEFAULT NULL,
  `appraisalplandate` datetime DEFAULT NULL,
  `appraisalapplicationdate` datetime DEFAULT NULL,
  `appraisallinkname` varchar(100) DEFAULT NULL,
  `appraisallinktel` varchar(100) DEFAULT NULL,
  `appraisalemail` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of appraisalapplication
-- ----------------------------
INSERT INTO `appraisalapplication` VALUES ('35ea6d0c-9ce0-4099-9f39-fb8f11c17c6f', '1f46314c-2fe9-4272-963b-4f2330c2daee', null, '大概好吧v', '发挥好vv那就', '韩剧承认以后', '让一个骨头汤鱼火锅', '1503878', '我头发吵架基本v几', '2014-08-06 00:00:00', '2015-09-07 00:00:00', '大概慈悲', '15868935', '5589655663', '未处理', '\0', null, null, null);
INSERT INTO `appraisalapplication` VALUES ('69ec9886-4589-498a-9662-19a1b1f0ad88', '577c8982-c23b-405a-b204-ee12bdde7c95', '333', 'y', 'y', 'f', 'f', '2015-09-11', '215-8-5', '2015-08-05 00:00:00', '0215-08-05 00:00:00', 'g', 'g', 'h', '已处理', '\0', null, null, null);
INSERT INTO `appraisalapplication` VALUES ('b2b4d628-ee99-4c7f-bef7-2ffa223978b5', 'admin', '123', '', '', '', '', '', '', null, null, '123', '123', '', '未处理', '\0', '2015-09-18 18:25:11', 'admin', null);

-- ----------------------------
-- Table structure for authpermission
-- ----------------------------
DROP TABLE IF EXISTS `authpermission`;
CREATE TABLE `authpermission` (
  `Code` varchar(50) COLLATE utf8_bin NOT NULL,
  `Name` varchar(50) COLLATE utf8_bin NOT NULL,
  `Description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `URL` varchar(255) COLLATE utf8_bin NOT NULL,
  `HttpType` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `Res` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `PCode` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `Sequence` int(11) DEFAULT NULL,
  `IsShow` bit(1) NOT NULL,
  `IsAvailable` bit(1) NOT NULL,
  `Operator` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `OperateTime` datetime NOT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of authpermission
-- ----------------------------
INSERT INTO `authpermission` VALUES ('00001', '商品管理', '', '/', 'HttpPost', 'icon-database', '', '2', '', '', 'admin', '2015-09-15 23:23:41');
INSERT INTO `authpermission` VALUES ('0000100001', '商品管理', '', '/goods/index', null, 'icon-add', '00001', '1', '', '', 'admin', '2015-09-15 23:24:51');
INSERT INTO `authpermission` VALUES ('0000100002', '订单管理', '', '/order/index', null, 'icon-magic', '00001', '2', '\0', '\0', 'admin', '2015-09-15 23:25:25');
INSERT INTO `authpermission` VALUES ('0000100003', '商品类别', '', '/goodstype/index', null, 'icon-select', '00001', '3', '', '', 'admin', '2015-09-15 23:27:24');
INSERT INTO `authpermission` VALUES ('0000100004', '新闻管理', '', '/News/Index', null, 'icon-edit', '00001', '5', '', '', 'admin', '2015-09-19 01:20:36');
INSERT INTO `authpermission` VALUES ('0000100005', '故障管理', '', '/fault/index', null, 'icon-log', '00001', '11', '', '', 'admin', '2015-09-19 01:20:55');
INSERT INTO `authpermission` VALUES ('0000100006', '故障类别', '', '/faulttype/index', null, 'icon-delete', '00001', '12', '', '', 'admin', '2015-09-21 23:07:26');
INSERT INTO `authpermission` VALUES ('0000100007', '广告管理', '', '/ad/index', null, 'icon-TWXValue', '00001', '14', '', '', 'admin', '2015-09-24 22:39:58');
INSERT INTO `authpermission` VALUES ('0000100008', '新闻类别', '', '/newstype/index', 'HttpGet', 'icon-select', '00001', '6', '', '', 'admin', '2015-10-14 09:31:11');
INSERT INTO `authpermission` VALUES ('0000100009', '快递查询', '', '/order/express', 'HttpGet', '', '00001', '111', '', '', 'admin', '2015-10-23 02:51:30');
INSERT INTO `authpermission` VALUES ('0000100010', 'App内容', '', '/app/index', 'HttpGet', '', '00001', '333', '', '', 'admin', '2015-11-03 00:43:28');
INSERT INTO `authpermission` VALUES ('0000100011', '快递公司维护', '', '/express/index', null, '', '00001', '77', '', '', 'admin', '2015-12-07 15:48:04');
INSERT INTO `authpermission` VALUES ('00002', '用户权限', '', '/', null, 'icon-persongMangnger', '', '4', '', '', 'admin', '2015-09-15 23:23:56');
INSERT INTO `authpermission` VALUES ('0000200001', '用户管理', '', '/AuthUser/Index', 'HttpGet', 'icon-person', '00002', '1', '', '', 'admin', '2015-09-15 23:27:55');
INSERT INTO `authpermission` VALUES ('0000200002', '角色管理', '', '/Role/Index', null, 'icon-role', '00002', '2', '', '', 'admin', '2015-09-15 23:28:20');
INSERT INTO `authpermission` VALUES ('0000200003', '权限管理', '', '/Permission/Index', null, 'icon-department', '00002', '3', '', '', 'admin', '2015-09-15 23:28:41');
INSERT INTO `authpermission` VALUES ('0000200004', '会员管理', '', '/User/Index', null, 'icon-persongMangnger', '00002', '8', '', '', 'admin', '2015-09-15 23:29:00');
INSERT INTO `authpermission` VALUES ('0000200005', '支付配置', '', '/Config/Index', null, 'icon-SetTD', '00002', '11', '', '', 'admin', '2015-09-20 11:51:52');
INSERT INTO `authpermission` VALUES ('0000200006', '网站配置', '', '/Config/webIndex', 'HttpGet', 'icon-SetTD', '00002', '11', '', '', 'admin', '2015-10-14 09:43:39');
INSERT INTO `authpermission` VALUES ('0000200007', '会员等级', '', '/grade/index', null, '', '00002', '9', '', '', 'admin', '2015-11-09 16:48:21');
INSERT INTO `authpermission` VALUES ('00003', '申请管理', '', '/', null, '', '', '7', '', '', 'admin', '2015-09-15 23:24:07');
INSERT INTO `authpermission` VALUES ('0000300001', '吊篮操作培训考核', '', '/appm/basket_train', null, 'icon-datameg', '00003', '1', '', '', 'admin', '2015-09-15 23:31:02');
INSERT INTO `authpermission` VALUES ('0000300002', '吊篮性能检测', '', '/appm/basket_check', 'HttpGet', 'icon-nav', '00003', '2', '', '', 'admin', '2015-09-15 23:31:18');
INSERT INTO `authpermission` VALUES ('0000300003', '吊篮安装检验', '', '/appm/basket_install', null, 'icon-settingRiZ', '00003', '3', '', '', 'admin', '2015-09-15 23:31:34');
INSERT INTO `authpermission` VALUES ('0000300004', '吊篮保养评审项目', '', '/appm/basket_keep', null, 'icon-settingGL', '00003', '4', '', '', 'admin', '2015-09-15 23:31:57');
INSERT INTO `authpermission` VALUES ('0000300005', '制造企业生产资质审批', '', '/appm/basket_made', null, 'icon-megSend', '00003', '5', '', '', 'admin', '2015-09-15 23:32:12');
INSERT INTO `authpermission` VALUES ('0000300006', '安装企业生产资质审批', '', '/appm/basket_rent', null, 'icon-set', '00003', '6', '', '', 'admin', '2015-09-15 23:32:27');
INSERT INTO `authpermission` VALUES ('0000300007', '施工升降机检验 ', '', '/appm/building_hoist', null, 'icon-dataset', '00003', '7', '', '', 'admin', '2015-09-15 23:32:43');
INSERT INTO `authpermission` VALUES ('0000300008', '附着式升降脚手架评审项目', '', '/appm/jsj_keep', null, 'icon-data', '00003', '11', '', '', 'admin', '2015-09-19 01:21:24');
INSERT INTO `authpermission` VALUES ('0000300009', '起重机械委托检验协议', '', '/appm/qzj_check', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('0000300010', '安全锁检验 ', '', '/appm/safe_lock', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('0000300011', '附着式升降脚手架检验 ', '', '/appm/staging_check', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('0000300012', '塔式起重机检验', '', '/appm/tower_crane', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('0000300013', '擦窗机安装检验', '', '/appm/winow_check', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('0000300014', '委托检验协议', '', '/appm/wt_check', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('0000300015', '委托检验协议', '', '/appm/xsweit_check', '', 'icon-wasitransducer', '00003', '12', '', '', 'admin', '2015-09-19 01:22:01');
INSERT INTO `authpermission` VALUES ('00004', '系统帮助', '', '/', null, 'icon-helpWord', '', '9', '', '', 'admin', '2015-09-15 23:24:29');
INSERT INTO `authpermission` VALUES ('0000400001', '帮助中心', '', '/Help/Index', null, 'icon-help', '00004', '1', '', '', 'admin', '2015-09-15 23:33:16');
INSERT INTO `authpermission` VALUES ('00005', '订单管理', '', '/', 'HttpGet', '', '', '1', '', '', 'admin', '2015-11-27 20:46:33');
INSERT INTO `authpermission` VALUES ('0000500001', '待付款', '', '/neworder/dfk', '', '', '00005', '1', '', '', 'admin', '2015-11-27 20:47:01');
INSERT INTO `authpermission` VALUES ('0000500002', '待发货', '', '/neworder/dfh', 'HttpGet', '', '00005', '2', '', '', 'admin', '2015-11-27 20:47:45');
INSERT INTO `authpermission` VALUES ('0000500003', '待收货', '', '/neworder/dsh/3', 'HttpGet', '', '00005', '3', '', '', 'admin', '2015-11-27 20:48:13');
INSERT INTO `authpermission` VALUES ('0000500004', '退款管理', '', '/neworder/tkgl', '', '', '00005', '5', '', '', 'admin', '2015-11-27 20:48:48');
INSERT INTO `authpermission` VALUES ('0000500005', '退货管理', '', '/neworder/thgl', 'HttpGet', '', '00005', '5', '', '', 'admin', '2015-11-27 20:49:11');
INSERT INTO `authpermission` VALUES ('0000500006', '完成订单', '', '/neworder/finish', '', '', '00005', '9', '', '', 'admin', '2015-11-27 20:49:48');
INSERT INTO `authpermission` VALUES ('0000500007', '取消订单', '', '/neworder/other', '', '', '00005', '10', '', '', 'admin', '2015-11-27 20:50:16');
INSERT INTO `authpermission` VALUES ('0000500008', '确认收货', '', '/neworder/dsh/4', null, '', '00005', '4', '', '', 'admin', '2015-11-29 16:02:41');
INSERT INTO `authpermission` VALUES ('0000500009', '退款成功', '', '/neworder/dsh/6', null, '', '00005', '6', '', '', 'admin', '2015-11-29 16:03:09');
INSERT INTO `authpermission` VALUES ('0000500010', '退款失败', '', '/neworder/dsh/7', null, '', '00005', '7', '', '', 'admin', '2015-11-29 16:03:22');

-- ----------------------------
-- Table structure for authrelation
-- ----------------------------
DROP TABLE IF EXISTS `authrelation`;
CREATE TABLE `authrelation` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PermissionCode` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `RoleName` varchar(50) COLLATE utf8_bin NOT NULL,
  `Operator` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `OperateTime` datetime NOT NULL,
  `IsShow` bit(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=133 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of authrelation
-- ----------------------------
INSERT INTO `authrelation` VALUES ('129', '00001', 'Manager', 'admin', '2015-09-16 11:58:23', '');
INSERT INTO `authrelation` VALUES ('130', '0000100001', 'Manager', 'admin', '2015-09-16 11:58:23', '');
INSERT INTO `authrelation` VALUES ('131', '0000100002', 'Manager', 'admin', '2015-09-16 11:58:23', '');
INSERT INTO `authrelation` VALUES ('132', '0000100003', 'Manager', 'admin', '2015-09-16 11:58:23', '');

-- ----------------------------
-- Table structure for authrole
-- ----------------------------
DROP TABLE IF EXISTS `authrole`;
CREATE TABLE `authrole` (
  `RoleName` varchar(50) COLLATE utf8_bin NOT NULL,
  `Title` varchar(50) COLLATE utf8_bin NOT NULL,
  `Description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `IsAvailable` bit(1) NOT NULL,
  `IsInner` bit(1) NOT NULL,
  `Priority` int(11) DEFAULT NULL,
  `Sequence` int(11) DEFAULT NULL,
  `Operator` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `OperateTime` datetime NOT NULL,
  PRIMARY KEY (`RoleName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of authrole
-- ----------------------------
INSERT INTO `authrole` VALUES ('1', '2', '2', '', '\0', '3', '2', 'admin', '2015-09-18 16:59:28');
INSERT INTO `authrole` VALUES ('Admin', '超级管理员', '', '', '', '1', '1', 'admin', '2015-09-16 09:21:39');
INSERT INTO `authrole` VALUES ('Manager', '管理员', '', '', '', '2', '2', 'admin', '2015-09-15 23:23:12');

-- ----------------------------
-- Table structure for authuser
-- ----------------------------
DROP TABLE IF EXISTS `authuser`;
CREATE TABLE `authuser` (
  `UserName` varchar(50) NOT NULL,
  `UserNo` varchar(50) DEFAULT NULL,
  `RealName` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `IsAvailable` bit(1) DEFAULT NULL,
  `IsInner` bit(1) DEFAULT NULL,
  `Sequence` int(11) DEFAULT NULL,
  `Operator` varchar(50) DEFAULT NULL,
  `OperateTime` datetime DEFAULT NULL,
  `Remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`UserName`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of authuser
-- ----------------------------
INSERT INTO `authuser` VALUES ('admin', null, '管理员', '21232F297A57A5A743894A0E4A801FC3', '', '', '1', 'admin', '2015-09-16 09:18:24', '');
INSERT INTO `authuser` VALUES ('user1', null, '用户1', 'C4CA4238A0B923820DCC509A6F75849B', '', '\0', '2', 'admin', '2015-11-26 15:18:28', '');
INSERT INTO `authuser` VALUES ('新用户', null, '1', 'C4CA4238A0B923820DCC509A6F75849B', '', '\0', null, 'admin', '2015-09-18 16:57:36', '');

-- ----------------------------
-- Table structure for authuserpermission
-- ----------------------------
DROP TABLE IF EXISTS `authuserpermission`;
CREATE TABLE `authuserpermission` (
  `ID` int(11) NOT NULL,
  `UserName` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `PCode` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of authuserpermission
-- ----------------------------

-- ----------------------------
-- Table structure for authuserrole
-- ----------------------------
DROP TABLE IF EXISTS `authuserrole`;
CREATE TABLE `authuserrole` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(50) COLLATE utf8_bin NOT NULL,
  `RoleName` varchar(50) COLLATE utf8_bin NOT NULL,
  `Operator` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `OperateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of authuserrole
-- ----------------------------
INSERT INTO `authuserrole` VALUES ('1', 'admin', 'Admin', 'admin', '2015-11-26 15:12:28');
INSERT INTO `authuserrole` VALUES ('2', 'user1', 'Manager', 'admin', '2015-09-16 11:37:58');

-- ----------------------------
-- Table structure for basket_check
-- ----------------------------
DROP TABLE IF EXISTS `basket_check`;
CREATE TABLE `basket_check` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `cpmc` varchar(255) DEFAULT NULL COMMENT '产品名称',
  `ggxh` varchar(255) DEFAULT NULL COMMENT '规格型号',
  `ypbh` varchar(255) DEFAULT NULL COMMENT '样品编号',
  `ypsl` varchar(255) DEFAULT NULL COMMENT '样品数量',
  `scrq` varchar(255) DEFAULT NULL COMMENT '生产日期',
  `jylx` varchar(255) DEFAULT NULL COMMENT '检验类型',
  `wtdw` varchar(255) DEFAULT NULL COMMENT '委托单位',
  `scdw` varchar(255) DEFAULT NULL COMMENT '生产单位',
  `jydd` varchar(255) DEFAULT NULL COMMENT '检验地点',
  `jysj` varchar(255) DEFAULT NULL COMMENT '检验时间',
  `jyyj` varchar(255) DEFAULT NULL COMMENT '检验依据',
  `jyjl` varchar(255) DEFAULT NULL COMMENT '检验结论',
  `bz` varchar(255) DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basket_check
-- ----------------------------
INSERT INTO `basket_check` VALUES ('2f1bb92e-1d26-4ff4-be66-cd8c15e4076f', 'value', null, '1', '2', '3', '4', '5', '6', '7', '8', '9', '`10', '11', '121', '13');
INSERT INTO `basket_check` VALUES ('acdfe510-7db8-407a-a76d-17a98e4b5a31', 'admin', '2016-08-15 16:15:16', '2', '2', '3', '4', '5', '6', '7', '78', '8', '9', '9', '9', '9');

-- ----------------------------
-- Table structure for basket_install
-- ----------------------------
DROP TABLE IF EXISTS `basket_install`;
CREATE TABLE `basket_install` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `gcmc` varchar(255) DEFAULT NULL COMMENT '工程名称',
  `sgdd` varchar(255) DEFAULT NULL COMMENT '施工地点',
  `sydw` varchar(255) DEFAULT NULL COMMENT '使用单位',
  `jldw` varchar(255) DEFAULT NULL COMMENT '监理单位',
  `sbmc` varchar(255) DEFAULT NULL COMMENT '设备名称',
  `azdw` varchar(255) DEFAULT NULL COMMENT '安装单位',
  `sbxh` varchar(255) DEFAULT NULL COMMENT '设备型号',
  `sbbh` varchar(255) DEFAULT NULL COMMENT '设备编号',
  `sccj` varchar(255) DEFAULT NULL COMMENT '生产厂家',
  `aqsbh` varchar(255) DEFAULT NULL COMMENT '安全锁编号',
  `tzsbsczzxkz` varchar(255) DEFAULT NULL COMMENT '特种设备生产制造许可证',
  `cqbh` varchar(255) DEFAULT NULL COMMENT '产权编号',
  `ccrq` varchar(255) DEFAULT NULL COMMENT '出厂日期',
  `jygd` varchar(255) DEFAULT NULL COMMENT '检验高度',
  `szzobbh` varchar(255) DEFAULT NULL COMMENT '数字兆欧表编号',
  `szzobyqzk` varchar(255) DEFAULT NULL COMMENT '数字兆欧表仪器状况',
  `wsdjbh` varchar(255) DEFAULT NULL COMMENT '温湿度计编号',
  `wsdjyqzk` varchar(255) DEFAULT NULL COMMENT '温湿度计仪器状况',
  `szwybbh` varchar(255) DEFAULT NULL COMMENT '数字万用表编号',
  `szwybyqzk` varchar(255) DEFAULT NULL COMMENT '数字万用表仪器状况',
  `scbh` varchar(255) DEFAULT NULL COMMENT '塞尺编号',
  `scyqzk` varchar(255) DEFAULT NULL COMMENT '塞尺仪器状况',
  `gzcbh` varchar(255) DEFAULT NULL COMMENT '钢直尺编号',
  `gzcyqzk` varchar(255) DEFAULT NULL COMMENT '钢直尺仪器状况',
  `szjdcbh` varchar(255) DEFAULT NULL COMMENT '数字角度尺编号',
  `szjdcyqzk` varchar(255) DEFAULT NULL COMMENT '数字角度尺仪器状况',
  `fsybh` varchar(255) DEFAULT NULL COMMENT '风速仪编号',
  `fsyyqzk` varchar(255) DEFAULT NULL COMMENT '风速仪仪器状况',
  `ybkcbh` varchar(255) DEFAULT NULL COMMENT '游标卡尺编号',
  `ybkcyqzk` varchar(255) DEFAULT NULL COMMENT '游标卡尺仪器状况',
  `gjc30mbh` varchar(255) DEFAULT NULL COMMENT '钢卷尺30m编号',
  `gjc30mzxkz` varchar(255) DEFAULT NULL COMMENT '钢卷尺30m仪器状况',
  `gjc5mbh` varchar(255) DEFAULT NULL COMMENT '钢卷尺5m编号',
  `gjc5mzxkz` varchar(255) DEFAULT NULL COMMENT '钢卷尺5m仪器状况',
  `bzxmbhgs` varchar(255) DEFAULT NULL COMMENT '保证项目不合格数',
  `ybxmbhgs` varchar(255) DEFAULT NULL COMMENT '一般项目不合格数',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basket_install
-- ----------------------------
INSERT INTO `basket_install` VALUES ('7861ad3b-0bbb-4369-819e-2e74c4bd6817', 'value1', '2016-08-13 19:52:06', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');
INSERT INTO `basket_install` VALUES ('8e3d1b32-d22e-4228-ad12-bd25d8e41852', 'value', '2016-08-13 19:53:00', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14', '15', '6171', '181', '19', '20', '21', '22', '32', '21', '21', 'u', 'u', 'h', 'b', 'n', 'g', 'f', 'r', 'h', 'jk', 'nv', 'b');

-- ----------------------------
-- Table structure for basket_keep
-- ----------------------------
DROP TABLE IF EXISTS `basket_keep`;
CREATE TABLE `basket_keep` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `sbxh` text COMMENT '设备型号',
  `azdw` text COMMENT '安装单位',
  `sccj` text COMMENT '生产厂家',
  `tsjbh` text COMMENT '提升机编号',
  `aqscxkzbh` text COMMENT '安全生产许可证编号',
  `aqsbh` text COMMENT '安全锁编号',
  `ccrq` text COMMENT '设备编号/出厂日期',
  `yssl` text COMMENT '验收数量',
  `cpcchgzjyjg` text COMMENT '产品出厂合格证检验结果',
  `cpcchgzjl` text COMMENT '产品出厂合格证结论',
  `cpcchgznz` text COMMENT '产品出厂合格证备注',
  `cqdjzjyjg` text COMMENT '产权登记证检验结果',
  `cqdjzjl` text COMMENT '产权登记证检验结论',
  `cqdjzbz` text COMMENT '产权登记证检验备注',
  `aqsbdzsjyjg` text COMMENT '安全锁标定证书检验结果',
  `aqsbdzsjl` text COMMENT '安全锁标定证书结论',
  `aqsbdzsbz` text COMMENT '安全锁标定证书备注',
  `sysmsjyjg` text COMMENT '使用说明书检验结果',
  `sysmsjl` text COMMENT '使用说明书结论',
  `sysmsbz` text COMMENT '使用说明书备注',
  `gsscsbgjyjg` text COMMENT '钢丝绳质量保证书或测试报告检验结果',
  `gsscsbgjl` text COMMENT '钢丝绳质量保证书或测试报告结论',
  `gsscsbgbz` text COMMENT '钢丝绳质量保证书或测试报告备注',
  `aqscsbgjyjg` text COMMENT '安全绳及自锁器质量保证书或测试报告检验结果',
  `aqscsbgjl` text COMMENT '安全绳及自锁器质量保证书或测试报告结论',
  `aqscsbgbz` text COMMENT '安全绳及自锁器质量保证书或测试报告备注',
  `zyslgjczzmjyjg` text COMMENT '主要受力构建材质证明检验结果',
  `zyslgjczzmjl` text COMMENT '主要受力构建材质证明结论',
  `zyslgjczzmbz` text COMMENT '主要受力构建材质证明备注',
  `dlzcbyjljyjg` text COMMENT '吊篮转场保养记录（提升机、安全锁、电箱及结构件）检验结果',
  `dlzcbyjljl` text COMMENT '吊篮转场保养记录（提升机、安全锁、电箱及结构件）结论',
  `dlzcbyjlbz` text COMMENT '吊篮转场保养记录（提升机、安全锁、电箱及结构件）备注',
  `xxlwjyjg` text COMMENT '悬挂机构、悬吊平台的钢结构及焊缝应无明显变形、裂纹和严重锈蚀、无破损检验结果',
  `xxlwjl` text COMMENT '悬挂机构、悬吊平台的钢结构及焊缝应无明显变形、裂纹和严重锈蚀、无破损结论',
  `xxlwbz` text COMMENT '悬挂机构、悬吊平台的钢结构及焊缝应无明显变形、裂纹和严重锈蚀、无破损备注',
  `zyslgjyfhcjsjyqjyjg` text COMMENT '主要受力构件应符合厂家设计要求检验结果',
  `zyslgjyfhcjsjyqjl` text COMMENT '主要受力构件应符合厂家设计要求结论',
  `zyslgjyfhcjsjyqbz` text COMMENT '主要受力构件应符合厂家设计要求备注',
  `jgjyjg` text COMMENT '应有安全钢丝绳、工作钢丝绳分别独立悬挂装置检验结果',
  `jgjl` text COMMENT '应有安全钢丝绳、工作钢丝绳分别独立悬挂装置结论',
  `jgbz` text COMMENT '应有安全钢丝绳、工作钢丝绳分别独立悬挂装置备注',
  `jgjgljlsyqqjyjg` text COMMENT '结构件各连接螺栓应齐全检验结果',
  `jgjgljlsyqqjl` text COMMENT '结构件各连接螺栓应齐全结论',
  `jgjgljlsyqqbz` text COMMENT '结构件各连接螺栓应齐全备注',
  `gwwwjyjg` text COMMENT '钢印铭牌清晰，外表无破损，无缺件，无严重锈蚀检验结果',
  `gwwwjl` text COMMENT '钢印铭牌清晰，外表无破损，无缺件，无严重锈蚀结论',
  `gwwwbz` text COMMENT '钢印铭牌清晰，外表无破损，无缺件，无严重锈蚀备注',
  `ywjyjg` text COMMENT '油位必须达到说明书的规定，无漏油现象检验结果',
  `ywjl` text COMMENT '油位必须达到说明书的规定，无漏油现象结论',
  `ywbz` text COMMENT '油位必须达到说明书的规定，无漏油现象备注',
  `jyjg41` text COMMENT '吊篮钢丝绳各项要求检验结果',
  `jl41` text COMMENT '吊篮钢丝绳各项要求结论',
  `bz41` text COMMENT '吊篮钢丝绳各项要求备注',
  `jyjg42` text COMMENT '安全钢丝绳各项检验结果',
  `jl42` text COMMENT '安全钢丝绳各项结论',
  `bz42` text COMMENT '安全钢丝绳各项备注',
  `jyjg43` text COMMENT '钢丝绳应报废检验结果',
  `jl43` text COMMENT '钢丝绳应报废结论',
  `bz43` text COMMENT '钢丝绳应报废备注',
  `jyjg51` text COMMENT '产品标牌检验结果',
  `jl51` text COMMENT '产品标牌结论',
  `bz51` text COMMENT '产品标牌结论备注',
  `jyjg52` text COMMENT '重量限载的警示标志检验结果',
  `jl52` text COMMENT '重量限载的警示标志结论',
  `bz52` text COMMENT '重量限载的警示标志备注',
  `jyjg6` text COMMENT '配重检验结果',
  `jl6` text COMMENT '配重结论',
  `bz6` text COMMENT '配重备注',
  `jyjg71` text COMMENT '安全装置检验结果',
  `jl71` text COMMENT '安全装置检验结论',
  `bz71` text COMMENT '安全装置备注',
  `jyjg72` text COMMENT '手动释放装置检验结果',
  `jl72` text COMMENT '手动释放装置结论',
  `bz72` text COMMENT '手动释放装置备注',
  `jyjg73` text COMMENT '专用的挂设安全带的安全绳检验结果',
  `jl73` text COMMENT '专用的挂设安全带的安全绳结论',
  `bz73` text COMMENT '专用的挂设安全带的安全绳备注',
  `jyjg8` text COMMENT '安全锁检验结果',
  `jl8` text COMMENT '安全锁检验结论',
  `bz8` text COMMENT '安全锁检验备注',
  `jyjg91` text COMMENT '电气元件检验结果',
  `jl91` text COMMENT '电气元件检验结论',
  `bz91` text COMMENT '电气元件检验备注',
  `jyjg92` text COMMENT '悬吊平台急停按钮检验结果',
  `jl92` text COMMENT '悬吊平台急停按钮检验结论',
  `bz92` text COMMENT '悬吊平台急停按钮检验备注',
  `jyjg93` text COMMENT '专用开关箱检验结果',
  `jl93` text COMMENT '专用开关箱检验结论',
  `bz93` text COMMENT '专用开关箱检验备注',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basket_keep
-- ----------------------------
INSERT INTO `basket_keep` VALUES ('06bf04b1-11f9-4ae1-8ad8-ebf4ed362908', 'value', '2016-08-14 11:21:58', '2', '1', '1', 'r', 't', 'y', 'u', 'u', 'i', 'o', 'n', 'j', 'g', 'h', 'k', 'l', 'g', 'h', 'v', 'b', 'v', 't', 'h', 'j', 'c', 'bv', 'u', 'i', 'jg', 'n', 'g', 'h', 'k', 'u', 'q', 't', 'y', 'ui', 'hg', 'v', 'b', 'n', 'j', 'k', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'q', 'u', 'i', 'o', 'p', 'h', 'j', 'k', 'l', 'j', 'k', 'j', 'b', 'n', 'm', 'w', 'm', 'u', 'y', 'y', 'i', 'i', 'i', 'i', 'o', 'q', 'q', 'w', 'w', 'q', 'p', 'q', 'p', 'p', 'p', 'p', 'p', 'p');
INSERT INTO `basket_keep` VALUES ('06bf04b1-11f9-4ae1-8ad8-ebf4ed362909', '2', '2016-08-12 16:08:10', '2', '2', '2', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for basket_made
-- ----------------------------
DROP TABLE IF EXISTS `basket_made`;
CREATE TABLE `basket_made` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `qymc` text COMMENT '企业名称',
  `qydz` text COMMENT '企业地址',
  `yb` text COMMENT '邮编',
  `zzjgdm` text COMMENT '组织机构代码',
  `lxr` text COMMENT '联系人',
  `gddh` text COMMENT '固定电话',
  `yddh` text COMMENT '移动电话',
  `dzyx` text COMMENT '电子邮箱',
  `cz` text COMMENT '传真',
  `yyzzzch` text COMMENT '营业执照注册号',
  `jjlx` text COMMENT '经济类型',
  `zczj` text COMMENT '注册资金（万元）',
  `gdzc` text COMMENT '固定资产（万元）',
  `qyzgzrs` text COMMENT '企业职工总人数',
  `kszzdlrq` text COMMENT '开始制造吊篮日期',
  `sqcpggxh` text COMMENT '申请产品规格型号',
  `qyjj` text,
  `fddbxm` text COMMENT '法代姓名',
  `fddbxb` text COMMENT '法代性别',
  `fddbzgxl` text COMMENT '法代最高学历',
  `fddbzw` text COMMENT '法代职务',
  `fddbzc` text COMMENT '法代职称',
  `fddbzy` text COMMENT '法代专业',
  `fddbgddh` text COMMENT '法代固定电话',
  `fddbyddh` text COMMENT '法代移动电话',
  `fddbzypx` text COMMENT '法代参加过何种专业或安全生产培训',
  `fddbpxsj` text COMMENT '法代培训时间',
  `fddbzsbh` text COMMENT '法代培训合格证书编号',
  `jsfzrxm` text COMMENT '技术负责姓名',
  `jsfzrxb` text COMMENT '技术负责性别',
  `jsfzrzgxl` text COMMENT '技术负责最高学历',
  `jsfzrzw` text COMMENT '技术负责职务',
  `jsfzrzc` text COMMENT '技术负责职称',
  `jsfzrzy` text COMMENT '技术负责专业',
  `jsfzrgddh` text COMMENT '技术负责固顶电话',
  `jsfzryddh` text COMMENT '技术负责移动电话',
  `jsfzrzypx` text COMMENT '技术负责移动电话',
  `jsfzrpxsj` text COMMENT '技术负责培训时间',
  `jsfzrzsbh` text COMMENT '技术负责证件编号',
  `zlfzrxm` text COMMENT '质负人姓名',
  `zlfzrxb` text COMMENT '质负人性别',
  `zlfzrzgxl` text COMMENT '质负人最高学历',
  `zlfzrzw` text COMMENT '质负人职务',
  `zlfzrzc` text COMMENT '质负人职称',
  `zlfzrzy` text COMMENT '质负人专业',
  `zlfzrgddh` text COMMENT '质负人固定电话',
  `zlfzryddh` text COMMENT '质负人移动电话',
  `zlfzrzypx` text COMMENT '质负人参加过何种专业或安全生产培训',
  `zlfzrpxsj` text COMMENT '质负人培训时间',
  `zlfzrzsbh` text COMMENT '质负人培训合格证书编号',
  `gzryxh1` text COMMENT '序号',
  `gzryxm1` text COMMENT '姓名',
  `gzryzw1` text COMMENT '职务',
  `gzryzc1` text COMMENT '职称',
  `gzryfzjg1` text COMMENT '发证机关',
  `gzryxl1` text COMMENT '学历',
  `gzryzy1` text COMMENT '专业',
  `gzryxh2` text COMMENT '序号',
  `gzryxm2` text COMMENT '姓名',
  `gzryzw2` text COMMENT '职务',
  `gzryzc2` text COMMENT '职称',
  `gzryfzjg2` text COMMENT '发证机关',
  `gzryxl2` text COMMENT '学历',
  `gzryzy2` text COMMENT '专业',
  `gzryxh3` text COMMENT '序号',
  `gzryxm3` text COMMENT '姓名',
  `gzryzw3` text COMMENT '职务',
  `gzryzc3` text COMMENT '职称',
  `gzryfzjg3` text COMMENT '发证机关',
  `gzryxl3` text COMMENT '学历',
  `gzryzy3` text COMMENT '专业',
  `gzryxh4` text COMMENT '序号',
  `gzryxm4` text COMMENT '姓名',
  `gzryzw4` text COMMENT '职务',
  `gzryzc4` text COMMENT '职称',
  `gzryfzjg4` text COMMENT '发证机关',
  `gzryxl4` text COMMENT '学历',
  `gzryzy4` text COMMENT '专业',
  `gzryxh5` text COMMENT '序号',
  `gzryxm5` text COMMENT '姓名',
  `gzryzw5` text COMMENT '职务',
  `gzryzc5` text COMMENT '职称',
  `gzryfzjg5` text COMMENT '发证机关',
  `gzryxl5` text COMMENT '学历',
  `gzryzy5` text COMMENT '专业',
  `tzzyryxh1` text COMMENT '序号',
  `tzzyryxm1` text COMMENT '姓名',
  `tzzyrygz1` text COMMENT '工种',
  `tzzyryxh2` text COMMENT '序号',
  `tzzyryxm2` text COMMENT '姓名',
  `tzzyrygz2` text COMMENT '工种',
  `tzzyryxh3` text COMMENT '序号',
  `tzzyryxm3` text COMMENT '姓名',
  `tzzyrygz3` text COMMENT '工种',
  `tzzyryxh4` text COMMENT '序号',
  `tzzyryxm4` text COMMENT '姓名',
  `tzzyrygz4` text COMMENT '工种',
  `tzzyryxh5` text COMMENT '序号',
  `tzzyryxm5` text COMMENT '姓名',
  `tzzyrygz5` text COMMENT '工种',
  `zgzsfzjg1` text COMMENT '发证机构',
  `zgzszsbh1` text COMMENT '证书编号',
  `zgzsyxq1` text COMMENT '有效期',
  `zgzsfzjg2` text COMMENT '发证机构',
  `zgzszsbh2` text COMMENT '证书编号',
  `zgzsyxq2` text COMMENT '有效期',
  `zgzsfzjg3` text COMMENT '发证机构',
  `zgzszsbh3` text COMMENT '证书编号',
  `zgzsyxq3` text COMMENT '有效期',
  `zgzsfzjg4` text COMMENT '发证机构',
  `zgzszsbh4` text COMMENT '证书编号',
  `zgzsyxq4` text COMMENT '有效期',
  `zgzsfzjg5` text COMMENT '发证机构',
  `zgzszsbh5` text COMMENT '证书编号',
  `zgzsyxq5` text COMMENT '有效期',
  `mxxh1` text COMMENT '序号',
  `mxsbmc1` text COMMENT '设备名称',
  `mxgg1` text COMMENT '型号/规格',
  `mxsl1` text COMMENT '数量(台)',
  `mxzzs1` text COMMENT '制造厂商',
  `mxxh2` text COMMENT '序号',
  `mxsbmc2` text COMMENT '设备名称',
  `mxgg2` text COMMENT '型号/规格',
  `mxsl2` text COMMENT '数量(台)',
  `mxzzs2` text COMMENT '制造厂商',
  `mxxh3` text COMMENT '序号',
  `mxsbmc3` text COMMENT '设备名称',
  `mxgg3` text COMMENT '型号/规格',
  `mxsl3` text COMMENT '数量(台)',
  `mxzzs3` text COMMENT '制造厂商',
  `mxxh4` text COMMENT '序号',
  `mxsbmc4` text COMMENT '设备名称',
  `mxgg4` text COMMENT '型号/规格',
  `mxsl4` text COMMENT '数量(台)',
  `mxzzs4` text COMMENT '制造厂商',
  `mxxh5` text COMMENT '序号',
  `mxsbmc5` text COMMENT '设备名称',
  `mxgg5` text COMMENT '型号/规格',
  `mxsl5` text COMMENT '数量(台)',
  `mxzzs5` text COMMENT '制造厂商',
  `jyylmxxh1` text COMMENT '序号',
  `jyylmxmc1` text COMMENT '名称',
  `jyylmxgg1` text COMMENT '型号/规格',
  `jyylmxsl1` text COMMENT '数量(台)',
  `jyylmxyxq1` text COMMENT '有效期',
  `jyylmxxh2` text COMMENT '序号',
  `jyylmxmc2` text COMMENT '名称',
  `jyylmxgg2` text COMMENT '型号/规格',
  `jyylmxsl2` text COMMENT '数量(台)',
  `jyylmxyxq2` text COMMENT '有效期',
  `jyylmxxh3` text COMMENT '序号',
  `jyylmxmc3` text COMMENT '名称',
  `jyylmxgg3` text COMMENT '型号/规格',
  `jyylmxsl3` text COMMENT '数量(台)',
  `jyylmxyxq3` text COMMENT '有效期',
  `jyylmxxh4` text COMMENT '序号',
  `jyylmxmc4` text COMMENT '名称',
  `jyylmxgg4` text COMMENT '型号/规格',
  `jyylmxsl4` text COMMENT '数量(台)',
  `jyylmxyxq4` text COMMENT '有效期',
  `jyylmxxh5` text COMMENT '序号',
  `jyylmxmc5` text COMMENT '名称',
  `jyylmxgg5` text COMMENT '型号/规格',
  `jyylmxsl5` text COMMENT '数量(台)',
  `jyylmxyxq5` text COMMENT '有效期',
  `yjylnd1` text COMMENT '年度',
  `yjylggxh1` text COMMENT '规格型号',
  `yjylcl1` text COMMENT '产量',
  `yjylxssr1` text COMMENT '销售收入',
  `yjylbz1` text COMMENT '备注',
  `yjylnd2` text COMMENT '年度',
  `yjylggxh2` text COMMENT '规格型号',
  `yjylcl2` text COMMENT '产量',
  `yjylxssr2` text COMMENT '销售收入',
  `yjylbz2` text COMMENT '备注',
  `yjylnd3` text COMMENT '年度',
  `yjylggxh3` text COMMENT '规格型号',
  `yjylcl3` text COMMENT '产量',
  `yjylxssr3` text COMMENT '销售收入',
  `yjylbz3` text COMMENT '备注',
  `yjylnd4` text COMMENT '年度',
  `yjylggxh4` text COMMENT '规格型号',
  `yjylcl4` text COMMENT '产量',
  `yjylxssr4` text COMMENT '销售收入',
  `yjylbz4` text COMMENT '备注',
  `yjylnd5` text COMMENT '年度',
  `yjylggxh5` text COMMENT '规格型号',
  `yjylcl5` text COMMENT '产量',
  `yjylxssr5` text COMMENT '销售收入',
  `yjylbz5` text COMMENT '备注',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basket_made
-- ----------------------------
INSERT INTO `basket_made` VALUES ('13f324b9-c336-4a7d-ab76-ded1944cae97', 'value', '2016-08-14 14:04:10', 'u', 'u', 'u', 'i', '', 'i', 'o', 'o', 'o', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, 'w', 'w', 'w', 'q', 'q', 'q', null, null, null, null, null, null, null, null, null, '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
INSERT INTO `basket_made` VALUES ('19459cf0-7d31-47d2-96ba-a3acdcb96364', '11', '2016-08-14 14:03:03', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for basket_rent
-- ----------------------------
DROP TABLE IF EXISTS `basket_rent`;
CREATE TABLE `basket_rent` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `QYQYMC` text COMMENT '企业企业名称',
  `QYQYDZ` text COMMENT '企业企业地址',
  `QYYB` text COMMENT '企业邮编',
  `QYZZJGDM` text COMMENT '企业组织机构代码',
  `QYLXR` text COMMENT '企业联系人',
  `QYGDDH` text COMMENT '企业固定电话',
  `QYYDDH` text COMMENT '企业移动电话',
  `QYDZYX` text COMMENT '企业电子邮箱',
  `QYCZ` text COMMENT '企业传真',
  `QYYYZZZCH` text COMMENT '企业营业执照注册号',
  `QYZCRQ` text COMMENT '企业注册日期',
  `QYYYZZDJJG` text COMMENT '企业营业执照登记机构',
  `QYJJLX` text COMMENT '企业经济类型',
  `QYZCZJ` text COMMENT '企业注册资金',
  `QYGDZC` text COMMENT '企业固定资产',
  `QYCSDLYWRS` text COMMENT '企业从事吊篮业务人数',
  `QYQYZGZRS` text COMMENT '企业企业职工总人数',
  `QYCZYDLSL` text COMMENT '企业出租用吊篮数量',
  `QYKSCSDLYWRQ` text COMMENT '企业开始从事吊篮业务日期',
  `QYQYJJ` text COMMENT '企业企业简介',
  `QYFRXM` text COMMENT '企业法人姓名',
  `QYFRXB` text COMMENT '企业法人性别',
  `QYFRZGXL` text COMMENT '企业法人最高学历',
  `QYFRZW` text COMMENT '企业法人职务',
  `QYFRZC` text COMMENT '企业法人职称',
  `QYFRZY` text COMMENT '企业法人专业',
  `QYFRGDDH` text COMMENT '企业法人固定电话',
  `QYFRYDDH` text COMMENT '企业法人移动电话',
  `QYFRPX` text COMMENT '企业法人培训',
  `QYFRPXSJ` text COMMENT '企业法人培训时间',
  `QYFRPXHGZSBH` text COMMENT '企业法人培训合格证书编号',
  `QYJLXM` text COMMENT '企业经理姓名',
  `QYJLXB` text COMMENT '企业经理性别',
  `QYJLZGXL` text COMMENT '企业经理最高学历',
  `QYJLZW` text COMMENT '企业经理职务',
  `QYJLZC` text COMMENT '企业经理职称',
  `QYJLZY` text COMMENT '企业经理专业',
  `QYJLGDDH` text COMMENT '企业经理固定电话',
  `QYJLYDDH` text COMMENT '企业经理移动电话',
  `QYJLPX` text COMMENT '企业经理培训',
  `QYJLPXSJ` text COMMENT '企业经理培训时间',
  `QYJLPXHGZSBH` text COMMENT '企业经理培训合格证书编号',
  `QYJSXM` text COMMENT '企业技术姓名',
  `QYJSXB` text COMMENT '企业技术性别',
  `QYJSZGXL` text COMMENT '企业技术最高学历',
  `QYJSZW` text COMMENT '企业技术职务',
  `QYJSZC` text COMMENT '企业技术职称',
  `QYJSZY` text COMMENT '企业技术专业',
  `QYJSGDDH` text COMMENT '企业技术固定电话',
  `QYJSYDDH` text COMMENT '企业技术移动电话',
  `QYJSPX` text COMMENT '企业技术培训',
  `QYJSPXSJ` text COMMENT '企业技术培训时间',
  `QYJSPXHGZSBH` text COMMENT '企业技术培训合格证书编号',
  `GLRYXH1` text COMMENT '管理人员序号1',
  `GLRYXM1` text COMMENT '管理人员姓名1',
  `GLRYZW1` text COMMENT '管理人员职务1',
  `GLRYZC1` text COMMENT '管理人员职称1',
  `GLRYXL1` text COMMENT '管理人员学历1',
  `GLRYZY1` text COMMENT '管理人员专业1',
  `GLRYSFZHM1` text COMMENT '管理人员身份证号码1',
  `GLRYXH2` text COMMENT '管理人员序号2',
  `GLRYXM2` text COMMENT '管理人员姓名2',
  `GLRYZW2` text COMMENT '管理人员职务2',
  `GLRYZC2` text COMMENT '管理人员职称2',
  `GLRYXL2` text COMMENT '管理人员学历2',
  `GLRYZY2` text COMMENT '管理人员专业2',
  `GLRYSFZHM2` text COMMENT '管理人员身份证号码2',
  `GLRYXH3` text COMMENT '管理人员序号3',
  `GLRYXM3` text COMMENT '管理人员姓名3',
  `GLRYZW3` text COMMENT '管理人员职务3',
  `GLRYZC3` text COMMENT '管理人员职称3',
  `GLRYXL3` text COMMENT '管理人员学历3',
  `GLRYZY3` text COMMENT '管理人员专业3',
  `GLRYSFZHM3` text COMMENT '管理人员身份证号码3',
  `GLRYXH4` text COMMENT '管理人员序号4',
  `GLRYXM4` text COMMENT '管理人员姓名4',
  `GLRYZW4` text COMMENT '管理人员职务4',
  `GLRYZC4` text COMMENT '管理人员职称4',
  `GLRYXL4` text COMMENT '管理人员学历4',
  `GLRYZY4` text COMMENT '管理人员专业4',
  `GLRYSFZHM4` text COMMENT '管理人员身份证号码4',
  `GLRYXH5` text COMMENT '管理人员序号5',
  `GLRYXM5` text COMMENT '管理人员姓名5',
  `GLRYZW5` text COMMENT '管理人员职务5',
  `GLRYZC5` text COMMENT '管理人员职称5',
  `GLRYXL5` text COMMENT '管理人员学历5',
  `GLRYZY5` text COMMENT '管理人员专业5',
  `GLRYSFZHM5` text COMMENT '管理人员身份证号码5',
  `JSGRXH1` text COMMENT '技术工人序号1',
  `JSGRXM1` text COMMENT '技术工人姓名1',
  `JSGRGZ1` text COMMENT '技术工人工种1',
  `JSGRXH2` text COMMENT '技术工人序号2',
  `JSGRXM2` text COMMENT '技术工人姓名2',
  `JSGRGZ2` text COMMENT '技术工人工种2',
  `JSGRXH3` text COMMENT '技术工人序号3',
  `JSGRXM3` text COMMENT '技术工人姓名3',
  `JSGRGZ3` text COMMENT '技术工人工种3',
  `JSGRXH4` text COMMENT '技术工人序号4',
  `JSGRXM4` text COMMENT '技术工人姓名4',
  `JSGRGZ4` text COMMENT '技术工人工种4',
  `JSGRXH5` text COMMENT '技术工人序号5',
  `JSGRXM5` text COMMENT '技术工人姓名5',
  `JSGRGZ5` text COMMENT '技术工人工种5',
  `ZGZSFZJG1` text COMMENT '资格证书发证机构1',
  `ZGZSZSBH1` text COMMENT '资格证书证书编号1',
  `ZGZSYXQ1` text COMMENT '资格证书有效期1',
  `ZGZSFZJG2` text COMMENT '资格证书发证机构2',
  `ZGZSZSBH2` text COMMENT '资格证书证书编号2',
  `ZGZSYXQ2` text COMMENT '资格证书有效期2',
  `ZGZSFZJG3` text COMMENT '资格证书发证机构3',
  `ZGZSZSBH3` text COMMENT '资格证书证书编号3',
  `ZGZSYXQ3` text COMMENT '资格证书有效期3',
  `ZGZSFZJG4` text COMMENT '资格证书发证机构4',
  `ZGZSZSBH4` text COMMENT '资格证书证书编号4',
  `ZGZSYXQ4` text COMMENT '资格证书有效期4',
  `ZGZSFZJG5` text COMMENT '资格证书发证机构5',
  `ZGZSZSBH5` text COMMENT '资格证书证书编号5',
  `ZGZSYXQ5` text COMMENT '资格证书有效期5',
  `WXJCSBXUH1` text COMMENT '维修检测设备序号1',
  `WXJCSBMC1` text COMMENT '维修检测设备名称1',
  `WXJCSBXH1` text COMMENT '维修检测设备型号1',
  `WXJCSBSL1` text COMMENT '维修检测设备数量1',
  `WXJCSBBZ1` text COMMENT '维修检测设备备注1',
  `WXJCSBXUH2` text COMMENT '维修检测设备序号2',
  `WXJCSBMC2` text COMMENT '维修检测设备名称2',
  `WXJCSBXH2` text COMMENT '维修检测设备型号2',
  `WXJCSBSL2` text COMMENT '维修检测设备数量2',
  `WXJCSBBZ2` text COMMENT '维修检测设备备注2',
  `WXJCSBXUH3` text COMMENT '维修检测设备序号3',
  `WXJCSBMC3` text COMMENT '维修检测设备名称3',
  `WXJCSBXH3` text COMMENT '维修检测设备型号3',
  `WXJCSBSL3` text COMMENT '维修检测设备数量3',
  `WXJCSBBZ3` text COMMENT '维修检测设备备注3',
  `WXJCSBXUH4` text COMMENT '维修检测设备序号4',
  `WXJCSBMC4` text COMMENT '维修检测设备名称4',
  `WXJCSBXH4` text COMMENT '维修检测设备型号4',
  `WXJCSBSL4` text COMMENT '维修检测设备数量4',
  `WXJCSBBZ4` text COMMENT '维修检测设备备注4',
  `WXJCSBXUH5` text COMMENT '维修检测设备序号5',
  `WXJCSBMC5` text COMMENT '维修检测设备名称5',
  `WXJCSBXH5` text COMMENT '维修检测设备型号5',
  `WXJCSBSL5` text COMMENT '维修检测设备数量5',
  `WXJCSBBZ5` text COMMENT '维修检测设备备注5',
  `GCYJXH1` text COMMENT '工程业绩序号1',
  `GCYJGCXMMC1` text COMMENT '工程业绩工程项目名称1',
  `GCYJZLDLTS1` text COMMENT '工程业绩租赁吊篮台数1',
  `GCYJZJZE1` text COMMENT '工程业绩租金总额1',
  `GCYJKJGSJ1` text COMMENT '工程业绩开竣工时间1',
  `GCYJBZ1` text COMMENT '工程业绩备注1',
  `GCYJXH2` text COMMENT '工程业绩序号2',
  `GCYJGCXMMC2` text COMMENT '工程业绩工程项目名称2',
  `GCYJZLDLTS2` text COMMENT '工程业绩租赁吊篮台数2',
  `GCYJZJZE2` text COMMENT '工程业绩租金总额2',
  `GCYJKJGSJ2` text COMMENT '工程业绩开竣工时间2',
  `GCYJBZ2` text COMMENT '工程业绩备注2',
  `GCYJXH3` text COMMENT '工程业绩序号3',
  `GCYJGCXMMC3` text COMMENT '工程业绩工程项目名称3',
  `GCYJZLDLTS3` text COMMENT '工程业绩租赁吊篮台数3',
  `GCYJZJZE3` text COMMENT '工程业绩租金总额3',
  `GCYJKJGSJ3` text COMMENT '工程业绩开竣工时间3',
  `GCYJBZ3` text COMMENT '工程业绩备注3',
  `GCYJXH4` text COMMENT '工程业绩序号4',
  `GCYJGCXMMC4` text COMMENT '工程业绩工程项目名称4',
  `GCYJZLDLTS4` text COMMENT '工程业绩租赁吊篮台数4',
  `GCYJZJZE4` text COMMENT '工程业绩租金总额4',
  `GCYJKJGSJ4` text COMMENT '工程业绩开竣工时间4',
  `GCYJBZ4` text COMMENT '工程业绩备注4',
  `GCYJXH5` text COMMENT '工程业绩序号5',
  `GCYJGCXMMC5` text COMMENT '工程业绩工程项目名称5',
  `GCYJZLDLTS5` text COMMENT '工程业绩租赁吊篮台数5',
  `GCYJZJZE5` text COMMENT '工程业绩租金总额5',
  `GCYJKJGSJ5` text COMMENT '工程业绩开竣工时间5',
  `GCYJBZ5` text COMMENT '工程业绩备注5',
  `CZDLXUH1` text COMMENT '出租吊栏序号1',
  `CZDLXH1` text COMMENT '出租吊栏型号1',
  `CZDLMC1` text COMMENT '出租吊栏名称1',
  `CZDLCCRQ1` text COMMENT '出租吊栏出厂日期1',
  `CZDLDLZZCJ1` text COMMENT '出租吊栏吊篮制造厂家1',
  `CZDLSL1` text COMMENT '出租吊栏数量1',
  `CZDLXUH2` text COMMENT '出租吊栏序号2',
  `CZDLXH2` text COMMENT '出租吊栏型号2',
  `CZDLMC2` text COMMENT '出租吊栏名称2',
  `CZDLCCRQ2` text COMMENT '出租吊栏出厂日期2',
  `CZDLDLZZCJ2` text COMMENT '出租吊栏吊篮制造厂家2',
  `CZDLSL2` text COMMENT '出租吊栏数量2',
  `CZDLXUH3` text COMMENT '出租吊栏序号3',
  `CZDLXH3` text COMMENT '出租吊栏型号3',
  `CZDLMC3` text COMMENT '出租吊栏名称3',
  `CZDLCCRQ3` text COMMENT '出租吊栏出厂日期3',
  `CZDLDLZZCJ3` text COMMENT '出租吊栏吊篮制造厂家3',
  `CZDLSL3` text COMMENT '出租吊栏数量3',
  `CZDLXUH4` text COMMENT '出租吊栏序号4',
  `CZDLXH4` text COMMENT '出租吊栏型号4',
  `CZDLMC4` text COMMENT '出租吊栏名称4',
  `CZDLCCRQ4` text COMMENT '出租吊栏出厂日期4',
  `CZDLDLZZCJ4` text COMMENT '出租吊栏吊篮制造厂家4',
  `CZDLSL4` text COMMENT '出租吊栏数量4',
  `CZDLXUH5` text COMMENT '出租吊栏序号5',
  `CZDLXH5` text COMMENT '出租吊栏型号5',
  `CZDLMC5` text COMMENT '出租吊栏名称5',
  `CZDLCCRQ5` text COMMENT '出租吊栏出厂日期5',
  `CZDLDLZZCJ5` text COMMENT '出租吊栏吊篮制造厂家5',
  `CZDLSL5` text COMMENT '出租吊栏数量5',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basket_rent
-- ----------------------------
INSERT INTO `basket_rent` VALUES ('1b61a78f-b4fa-414c-bd74-a56befd3d9b4', 'value1', '2016-08-14 17:26:40', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
INSERT INTO `basket_rent` VALUES ('b44b316a-535f-4480-91c4-da7f6c75ac03', 'value', '2016-08-14 17:27:47', '1', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '男', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);

-- ----------------------------
-- Table structure for basket_train
-- ----------------------------
DROP TABLE IF EXISTS `basket_train`;
CREATE TABLE `basket_train` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `xm` varchar(255) DEFAULT NULL COMMENT '姓名',
  `xb` varchar(255) DEFAULT NULL COMMENT '性别',
  `whcd` varchar(255) DEFAULT NULL COMMENT '文化程度',
  `lxdh` varchar(255) DEFAULT NULL COMMENT '联系电话',
  `zygl` varchar(255) DEFAULT NULL COMMENT '专业工龄',
  `stzk` varchar(255) DEFAULT NULL COMMENT '身体状况',
  `sfzh` varchar(255) DEFAULT NULL COMMENT '身份证号',
  `gzdw` varchar(255) DEFAULT NULL COMMENT '工作单位',
  `yb` varchar(255) DEFAULT NULL COMMENT '邮编',
  `yx` varchar(255) DEFAULT NULL COMMENT '邮箱',
  `brqz` varchar(255) DEFAULT NULL COMMENT '本人签字',
  `pxd` varchar(255) DEFAULT NULL COMMENT '培训点',
  `gzjl` varchar(255) DEFAULT NULL COMMENT '工作经历',
  `szdwyj` varchar(255) DEFAULT NULL COMMENT '所在单位意见',
  PRIMARY KEY (`Guid`),
  UNIQUE KEY `userid` (`userid`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basket_train
-- ----------------------------
INSERT INTO `basket_train` VALUES ('2f1bb92e-1d26-4ff4-be66-cd8c15e4076f', '123', '2016-08-11 14:03:39', '1', '男', '2', '3', '4', '5', '6', '7', '8', '9', '10', '小天鹅,雄宇,', '11', '21');

-- ----------------------------
-- Table structure for building_hoist
-- ----------------------------
DROP TABLE IF EXISTS `building_hoist`;
CREATE TABLE `building_hoist` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `GCMC` text COMMENT '工程名称',
  `SYDW` text COMMENT '使用单位',
  `SGDD` text COMMENT '施工地点',
  `JLDW` text COMMENT '监理单位',
  `AZDW` text COMMENT '安装单位',
  `AZFZR` text COMMENT '安装负责人',
  `SBMC` text COMMENT '设备名称',
  `SBXH` text COMMENT '设备型号',
  `ZZDW` text COMMENT '制造单位',
  `ZZXKZH` text COMMENT '制造许可证号',
  `CCBH` text COMMENT '出厂编号',
  `AZGZRQ` text COMMENT '安装告知日期',
  `BABH` text COMMENT '备案编号',
  `EDZZL` text COMMENT '额定载重量',
  `DLZL` text COMMENT '吊笼质量',
  `EDTSSD` text COMMENT '额定提升速度',
  `FZAQQXS` text COMMENT '防坠安全器形式',
  `DZZL` text COMMENT '对重质量',
  `TYSAZGD` text COMMENT '体验时安装高度',
  `ZYDGD` text COMMENT '自由端高度',
  `FQDS` text COMMENT '附墙道数',
  `DYFQGD` text COMMENT '第一附墙高度',
  `BZJGG` text COMMENT '标准节规格',
  `JYLX` text COMMENT '检验类型',
  `YQMC1` text COMMENT '仪器名称',
  `XH1` text COMMENT '型号',
  `BH1` text COMMENT '编号',
  `ZT1` text COMMENT '状态',
  `YQMC2` text COMMENT '仪器名称',
  `XH2` text COMMENT '型号',
  `BH2` text COMMENT '编号',
  `ZT2` text COMMENT '状态',
  `YQMC3` text COMMENT '仪器名称',
  `XH3` text COMMENT '型号',
  `BH3` text COMMENT '编号',
  `ZT3` text COMMENT '状态',
  `YQMC4` text COMMENT '仪器名称',
  `XH4` text COMMENT '型号',
  `BH4` text COMMENT '编号',
  `ZT4` text COMMENT '状态',
  `YQMC5` text COMMENT '仪器名称',
  `XH5` text COMMENT '型号',
  `BH5` text COMMENT '编号',
  `ZT5` text COMMENT '状态',
  `BZXMBHGS` text COMMENT '保证项目不合格数',
  `YBXMBHGS` text COMMENT '一般项目不合格数',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of building_hoist
-- ----------------------------
INSERT INTO `building_hoist` VALUES ('49f6f626-384d-46dd-a9b4-3c2031118321', 'value', '2016-08-14 17:53:12', 'j', 'j', 'j', 'l', '', 'h', 'hj', '', 'j', 'k', 'k', 'kl', 'll', 'l', 'l', '', '', '', '', '', '', '', '', '', '2', '2', '2', '2', '2', '4', '4', '4', null, null, null, null, null, null, null, null, null, null, null, null, 'q', 'w');
INSERT INTO `building_hoist` VALUES ('b7d6c605-abe6-4c56-86c7-1c2ae1ff229b', 'value1', '2016-08-14 17:50:55', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '');

-- ----------------------------
-- Table structure for cat
-- ----------------------------
DROP TABLE IF EXISTS `cat`;
CREATE TABLE `cat` (
  `catid` varchar(36) COLLATE utf8_bin NOT NULL,
  `goodsid` varchar(36) COLLATE utf8_bin NOT NULL,
  `userid` varchar(36) COLLATE utf8_bin NOT NULL,
  `goodssize` int(11) NOT NULL,
  PRIMARY KEY (`catid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of cat
-- ----------------------------
INSERT INTO `cat` VALUES ('01441ea2-745e-4df2-943a-a650736680eb', '0b59aee8-f586-456b-a03f-ee23483e6cdc', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '4');
INSERT INTO `cat` VALUES ('10be176a-ee9d-40de-ade9-b40c93afd142', '0ddaf879-0b84-4cd3-b604-8d547cee98f5', 'bbacc27f-7d86-46a5-89e3-4a0f3020453e', '1');
INSERT INTO `cat` VALUES ('1cf5becc-6b57-41d7-a49b-04cc0f6a1f37', '00000000-0000-0000-0000-000000000002', '60ed6597-1993-47a3-8360-4096993799d6', '2');
INSERT INTO `cat` VALUES ('1d242bfb-72f9-4c5a-8d56-c78db5a69bc3', '0b59aee8-f586-456b-a03f-ee23483e6cdc', 'b7c74be9-77af-402c-877c-217c27799cad', '2');
INSERT INTO `cat` VALUES ('626772ce-77bd-4642-b7ca-deccc93744ec', '3c4aa4b5-81b4-422a-9a0e-e35ff8a6b359', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '1');
INSERT INTO `cat` VALUES ('66b49e87-ce07-4549-bddc-29ed3df0ebe3', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', 'b7c74be9-77af-402c-877c-217c27799cad', '5');
INSERT INTO `cat` VALUES ('6a295d25-ec0a-4197-bee0-2508830b58da', '00000000-0000-0000-0000-000000000002', 'e38f126c-0051-4d93-b246-05d6297a75b5', '1');
INSERT INTO `cat` VALUES ('7a4043c9-043c-46a6-ad41-f470559f7f64', '00000000-0000-0000-0000-000000000004', '60ed6597-1993-47a3-8360-4096993799d6', '1');
INSERT INTO `cat` VALUES ('8fc3d3cb-8284-45f9-99d0-a4c3c97db1e5', '0c497af0-84d0-4282-a343-a8504f26f510', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '1');
INSERT INTO `cat` VALUES ('a45cc91b-be8c-40b2-ade9-00df98532913', '00000000-0000-0000-0000-000000000006', '8dfa10a3-fdd3-4a78-89f7-28af9996387a', '12');
INSERT INTO `cat` VALUES ('cbdd5dad-ab15-4ab5-9fcc-bbfb9ff5e05d', '92c803b8-f64b-4781-91c6-5e5bd734d092', 'd9ad4789-6e5c-4703-b5b8-f6afcce57f81', '3');
INSERT INTO `cat` VALUES ('d233508c-1bd4-43db-bfbc-6eb09accb4e2', 'e802a249-e41c-4392-8c79-a7fb43d427ff', 'ead5c475-6fbc-44f1-b4e7-ef8abf1aa3fe', '3');
INSERT INTO `cat` VALUES ('d26bdba1-3f2c-4a77-8c98-b8eefc628800', 'cebde7e5-4087-4a52-b5af-1db8450494d6', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '1');
INSERT INTO `cat` VALUES ('d60ca3ad-8ddd-428b-a35f-de782f308596', 'e802a249-e41c-4392-8c79-a7fb43d427ff', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '1');
INSERT INTO `cat` VALUES ('d913041e-3dd7-4945-813b-69f58aa86a30', '4793df4a-f08c-4c78-bf52-9c4fa6706ef2', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '1');
INSERT INTO `cat` VALUES ('e0cf647d-8386-4bf4-87ff-87aaa625d9ee', '0ddaf879-0b84-4cd3-b604-8d547cee98f5', '6c01f081-06cd-452b-a459-fda5a212dce9', '1');
INSERT INTO `cat` VALUES ('fd0b7a3a-4b39-4d2d-8408-10bcd25ba7c1', '90dcc85c-5fb6-4427-ba57-4b2a7ac844f6', 'c964d548-4908-4fc6-a078-75a3d00f3644', '3');

-- ----------------------------
-- Table structure for config
-- ----------------------------
DROP TABLE IF EXISTS `config`;
CREATE TABLE `config` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `Key` varchar(255) NOT NULL,
  `Value` varchar(255) NOT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of config
-- ----------------------------
INSERT INTO `config` VALUES ('015559c6-1c42-40f0-a470-5b746a2e9afc', 'Money_BaoYou', '100.00');
INSERT INTO `config` VALUES ('03319779-ae72-4b3d-903b-be8b821394dc', 'ExpressKey', '');
INSERT INTO `config` VALUES ('1879b3bb-d135-4860-9f9a-3dc8c62383cb', 'Address', '无锡市锡山经济技术开发区凤威路2号（外广场1号楼）');
INSERT INTO `config` VALUES ('2cf97ded-922a-4406-993f-c37d27f9bcde', 'Money_ZJCPJD', '188');
INSERT INTO `config` VALUES ('381286dc-0c7d-4379-a581-6a0f2eeb986a', 'Tel', '400-885-1817');
INSERT INTO `config` VALUES ('49e226ac-72a6-4cc5-a16b-8341617a6dfa', 'IndexKeyword', '后顾无忧,无忧商城');
INSERT INTO `config` VALUES ('50c3738d-a1f6-40d1-96a1-9ee5ae4d6ad8', 'Money_JiFen2', '1.00');
INSERT INTO `config` VALUES ('686710d1-fa22-4b89-b32a-53e616e56cd8', 'Money_JC', '188');
INSERT INTO `config` VALUES ('6cdf9ddb-ebf1-444b-a45c-4d894bcc34f6', 'Money_ZZ', '188');
INSERT INTO `config` VALUES ('7f00179e-7e75-4ed7-9ccc-51a321f61a32', 'Money_FBFASJ', '188');
INSERT INTO `config` VALUES ('8aeb23c8-22de-4e99-b089-832fe22b7771', 'Copyright', '2014-2015 huiguCMS. 后顾无忧有限公司 版权所有');
INSERT INTO `config` VALUES ('92618ece-ce33-4e80-b57a-3d366d0c8dec', 'ICP', '');
INSERT INTO `config` VALUES ('9577d674-c23d-4316-ac9b-3ffa280b52b6', 'Money_YouFei', '0.00');
INSERT INTO `config` VALUES ('a3be6461-3d41-497b-87ac-2799837874d0', 'Money_ZJSGJD', '188');
INSERT INTO `config` VALUES ('c7b88193-0da5-462e-aa3b-ca42b6082119', 'Money_PX', '1881');
INSERT INTO `config` VALUES ('cd6490ec-5c35-4c67-ac83-fd3f9e4b66d4', 'Money_FBFALZ', '188');
INSERT INTO `config` VALUES ('d0295670-6b25-496e-b8f0-d57641cb381a', 'Email', '996779265@qq.com');
INSERT INTO `config` VALUES ('deac3b1c-39f3-4414-b511-2c8d2627f656', 'Money_JiFen', '100');
INSERT INTO `config` VALUES ('f6dfae85-4ec5-405c-8fe8-7f16440ff04d', 'IndexDescription', '后顾无忧-让您的起重事业从此无忧');
INSERT INTO `config` VALUES ('fade4608-cf9a-459e-a747-7c95242d649d', 'IndexTitle', '后顾无忧-让您的起重事业从此无忧');

-- ----------------------------
-- Table structure for consumptionnote
-- ----------------------------
DROP TABLE IF EXISTS `consumptionnote`;
CREATE TABLE `consumptionnote` (
  `consumptionnoteid` varchar(36) NOT NULL DEFAULT '',
  `consumptionnotelogo` varchar(255) DEFAULT NULL,
  `consumptionnotedate` datetime NOT NULL,
  `consumptionnotetitle` varchar(255) NOT NULL,
  `consumptionnotecountmoney` double NOT NULL,
  `userid` varchar(36) NOT NULL,
  PRIMARY KEY (`consumptionnoteid`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of consumptionnote
-- ----------------------------
INSERT INTO `consumptionnote` VALUES ('00fead3e-3b0c-4fdb-8df7-4be156dd94e5', '', '2015-12-04 00:20:24', '购物-十芯插件', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('04918119-b7ab-457f-90f1-b3fe865d126a', '', '2015-12-11 00:13:12', '购物-航空插件', '49', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('08210250-3214-4d0e-b1b8-e411642875a0', '', '2015-11-13 00:35:50', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('0af0baa0-1ce4-4749-8e3b-139a3b860a4f', '', '2015-12-02 22:50:14', '购物-80提升机大齿轮', '0.1', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('0c4d7293-3d8e-4560-8426-1fb28826dfdb', '', '2015-12-05 01:09:34', '购物-后支架', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('0ef415ae-085e-44b3-9adc-fe9a0d8869cd', '', '2015-11-07 12:02:50', '购物-测试', '1', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('10833af0-66f8-45f9-a2d2-879c7c69ef93', '', '2015-09-28 13:48:56', '购物-齿轮盘', '720', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('128489bc-5d9d-4391-b54f-0406d1b37a76', '', '2015-09-19 22:48:38', '购物-航空插件,齿轮盘,涡轮,十芯插件', '920', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('130a8e35-a510-4a79-a77e-252184cdff40', '', '2015-10-02 11:15:53', '购物-齿轮盘', '120', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('141eedef-31a6-425c-b105-fe430ca071fd', '', '2015-09-21 14:00:59', '购物-齿轮盘', '120', 'bbacc27f-7d86-46a5-89e3-4a0f3020453e');
INSERT INTO `consumptionnote` VALUES ('1601c4d2-3669-407a-9c48-20d9d2d8afce', '', '2015-09-17 15:11:29', '购物-涡轮', '300', 'd9ad4789-6e5c-4703-b5b8-f6afcce57f81');
INSERT INTO `consumptionnote` VALUES ('1d117700-cb98-4a11-8cce-ac094e0f6269', '', '2015-11-27 00:38:11', '购物-摆臂', '90', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('1d1bf031-adba-4e83-a1fa-b7f8ea2c9855', '', '2015-11-19 09:34:29', '购物-提升机测试,压轮组件', '181.8', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('1e6c6f6e-9a3a-4be3-9914-d934661e7be1', '', '2015-11-13 00:10:54', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('1f480202-f0cf-49c9-b1dd-76abc6e20d8d', '', '2015-11-27 00:00:10', '购物-摆臂', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('1fac9d6e-6619-4883-a069-315b938de336', '', '2015-11-11 12:32:55', '购物-测试', '0', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('21667715-76a1-4fb4-8f6b-5f39ae19c676', '', '2015-09-29 15:38:15', '购物-航空插件,绳夹', '120', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('219284f6-f67b-4ef8-875d-636a2259f71f', '', '2015-11-21 15:28:46', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('22215872-5703-4f5f-8833-a4e99cb8b20d', '', '2015-09-05 12:56:59', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('22ae2954-6732-47dc-ae28-2a5a4fd8d6f2', '', '2015-12-07 02:24:50', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('23661e82-df06-4d7f-b7b8-5f0472043182', '', '2015-11-18 10:07:32', '购物-压轮组件,提升机测试', '225', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('260ba153-b8e9-4bf7-a5d7-06da10465d8f', '', '2015-11-13 11:37:35', '购物-测试,CJX2交流接触器', '45', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('26591d0b-1490-4eaf-9ec1-0254cb781209', '', '2015-09-05 13:16:51', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('26d85fc4-2f85-44b1-bfcd-40dc113d486e', '', '2015-11-12 00:31:56', '购物-测试', '0', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('2b32af68-453b-4822-9177-c5c37ec43b0a', '', '2015-10-26 11:25:12', '购物-测试,测试,测试,测试', '500', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('2ca3fe0c-84cf-449b-b9a9-fb83435887e7', '', '2015-11-13 00:31:25', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('2d9bc4ac-af74-4517-bdc4-2f05bc67a8da', '', '2015-12-05 00:33:31', '购物-后支架', '147', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('30180529-abe9-4ef2-b3ff-bdbbfb807a8f', '', '2015-11-15 12:48:38', '购物-测试', '1', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('31f70cd0-752c-4e59-bc92-ee2d530dedb2', '', '2015-11-30 00:58:41', '购物-电缆线', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('33bc3058-279e-4bba-87a1-96ea0394757d', '', '2015-11-13 00:20:59', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('34d6a9de-3dfc-4dab-aadb-6f3955dbb8ea', '', '2015-11-22 23:47:58', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('357e1cc4-40a7-4b58-ba51-f5d07febaa57', '', '2015-11-27 00:14:18', '购物-80提升机大齿轮', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('36226211-01e6-4df2-a55c-871d84c0798e', '', '2015-11-19 17:52:18', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('39a4323f-7bb9-477c-b7cd-31e452970ef2', '', '2015-11-21 15:27:57', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('3c691948-6361-408d-ac81-ea25b0ad9be3', '', '2015-12-11 00:04:16', '购物-五芯工业插件', '49', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('3ca3a751-9073-4083-afee-63eed7c0af8a', '', '2015-12-07 19:25:09', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('3d8597b7-0c61-49f2-b805-53e31de4adb5', '', '2015-11-16 21:47:40', '购物-测试', '0', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('3f0dd1e8-780d-4065-a56c-78bf61ea7cb3', '', '2015-11-01 01:15:40', '购物-测试', '200', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('431cfc49-d725-4a9e-a71e-49824e0ab663', '', '2015-11-29 14:41:32', '购物-电缆线', '135', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('46a44ea5-da76-4655-964a-64eed5b49c23', '', '2015-11-15 12:20:24', '购物-提升机测试', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('482d947a-3dfc-4fe8-adee-0e96e404c1b9', '', '2015-12-01 23:45:13', '购物-电缆线', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('4b1eb566-e674-4fef-9f8a-17f29e4e3af0', '', '2015-09-05 12:31:05', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('4b8cc54e-ae77-4877-9e3a-c2c5a4603edd', '', '2015-09-28 10:28:29', '购物-齿轮盘', '120', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('4f8318fb-38f1-418d-b7d3-a9427e29e93d', '', '2015-11-29 10:47:18', '购物-80提升机大齿轮', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('50e1be99-883e-4337-b88e-2f284ebf39e0', '', '2015-12-01 20:45:02', '购物-摆臂', '45', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('50f41258-b11a-4091-bc74-d9fbedafcd18', '', '2015-09-10 15:00:30', '购物-美妆2,美食,香水', '50', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('5321ff82-f3ec-4ee1-b6cb-7b4de5701103', '', '2015-11-14 01:39:34', '购物-压轮组件', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('546771dc-56d0-46cf-b816-24eeaca8f735', '', '2015-12-03 11:44:37', '购物-风叶', '98', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('54e5e4eb-c63d-410b-9b65-d2e6dd27211a', '', '2015-09-27 22:38:36', '购物-齿轮盘', '120', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('58338728-5052-4d31-81d1-5bc4ee814e2b', '', '2015-11-22 23:32:07', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('5ce39635-68ca-4c95-a071-2710474a3205', '', '2015-12-04 00:36:30', '购物-十芯插件', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('5ea8588a-01b6-46b4-8226-d221c860f886', '', '2015-11-27 12:50:34', '购物-80提升机大齿轮', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('60eb44da-1800-4ecc-a11a-7c9cd07acdc5', '', '2015-11-13 00:01:34', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('65221a31-b5b2-490e-983d-6a1657ca4d10', '', '2015-11-21 13:51:02', '购物-提升机测试', '2.7', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('65d37d58-92b9-4c38-bb32-39b95dd4422c', '', '2015-11-19 23:02:21', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('66b23d89-5dc5-400b-939b-4cefc9419d3f', '', '2015-11-29 15:45:48', '购物-80提升机大齿轮', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('67f2f4a1-b358-4d91-b513-8f2eef98ce29', '', '2015-09-05 11:14:33', '购物-美妆2,休闲女装,休闲女装', '152', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('68482c48-e964-4dfd-9ff5-36e32cc11091', '', '2015-09-22 22:49:53', '购物-涡轮,涡轮', '600', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('6b2bacee-fb61-44d2-ac20-8d2dfec8eacb', '', '2015-12-02 22:35:07', '购物-电缆线', '5', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('6b6e1318-e0f6-42ae-9975-828c328a7199', '', '2015-10-25 10:09:02', '购物-CJX2交流接触器', '55', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('6c9ef806-237b-4cdb-8ed5-ac732d61f771', '', '2015-11-07 13:20:19', '购物-测试,CJX2交流接触器,测试,测试,测试', '7', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('6cae7adc-ded4-4a93-9ff7-58a36ef31793', '', '2015-11-04 11:02:09', '购物-测试', '200', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('6da90a47-bce8-409b-86c0-7d16a0f3e90b', '', '2015-11-21 15:07:53', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('710627a8-e13d-4e4f-88ba-7017e3fae127', '', '2015-11-26 17:09:23', '购物-压轮组件', '45', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('73e9dae5-3968-4c42-bdc9-0587638faa18', '', '2015-09-05 11:01:33', '购物-美衣,美妆2,美食,美食', '60', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('754d4dc1-dd3f-473a-86a9-1c52cfe1d7b0', '', '2015-12-05 01:06:47', '购物-后支架', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('75a1dbf3-6cd1-4c27-b580-cc4f118d7e59', '', '2015-12-06 23:53:41', '购物-方孔衬圈', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('7a72e9ff-dd88-48c8-8e7e-aae4157be447', '', '2015-12-03 11:45:56', '购物-滚子', '49', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('7dd4c05c-b475-41db-96ac-337cbce2db8d', '', '2015-09-05 13:21:57', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('7e966e30-82cd-4125-b085-abcf78afc0a6', '', '2015-11-18 23:40:00', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('7eb5ebc7-ae2a-48aa-bbfd-420ad2f77717', '', '2015-12-03 00:48:56', '购物-后支架', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('80950eca-51e9-4a10-816c-e89e456f14f6', '', '2015-12-06 14:37:18', '购物-压轮组件,电缆线', '245', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('80d76bcf-7521-40c8-9366-56aa45710462', '', '2015-09-11 22:22:52', '购物-美妆2', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('81f9a45d-7ea4-4f7b-a9a7-a40f9230047e', '', '2015-11-26 23:59:23', '购物-电缆线', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('82499e66-20b3-4fa5-a6a0-d9a307c69bc9', '', '2015-11-12 13:20:01', '购物-提升机测试', '45', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('827f91fb-394c-41eb-90f2-2a07c8edb866', '', '2015-12-01 23:48:22', '购物-80提升机大齿轮', '0.1', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('857d748c-bd40-4447-8fd6-b89f5890e973', '', '2015-09-05 12:13:03', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('86986e9c-89b9-455f-ba80-d4a2b64ff236', '', '2015-11-07 13:20:52', '购物-测试', '1', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('86a2c71a-8db4-4391-826c-0722db3ca8ce', '', '2015-11-21 15:11:51', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('880c3101-7552-496c-87cf-fc49bfdbf33c', '', '2015-11-13 00:14:06', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('88fcaad0-dd2d-4b2a-ac44-f1863c1d0361', '', '2015-11-12 23:59:33', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('89d8a45e-06e4-4469-af74-cfa31da75e69', '', '2015-10-25 10:29:02', '购物-CJX2交流接触器', '55', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('8b033fe8-0909-4869-83d3-efb003ffde57', '', '2015-12-06 22:45:52', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('8b65b160-c078-4abb-8828-094c9ed16ded', '', '2015-09-28 14:18:24', '购物-齿轮盘', '120', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('8bc9b18d-0bf7-4190-b6a0-12143725a64d', '', '2015-11-29 14:51:47', '购物-滚子', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('8cb4d75e-c051-4237-b1aa-4033fafbbdc6', '', '2015-11-18 23:51:59', '购物-提升机测试', '1.8', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('8cf0a1bb-fb0c-4b27-bda5-c709a791a203', '', '2015-11-25 18:28:27', '购物-不锈钢电箱外壳', '180', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('8ef43119-69e1-41fa-ac7a-34a2dd4fcd43', '', '2015-11-23 14:41:23', '购物-提升机测试', '0.9', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('90d39ce4-2733-4ce9-9ecb-e5517b705832', '', '2015-10-25 13:14:05', '购物-CJX2交流接触器', '55', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('910e482e-4e7b-4654-93d0-e71d0bd8c746', '', '2015-09-28 11:01:00', '购物-航空插件,航空插件,齿轮盘', '320', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('92793677-fb14-4dfd-9212-ab11150f7ba0', '', '2015-11-29 14:34:30', '购物-电缆线', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('96436f31-f8e0-4620-9e27-9f5d2bfd4007', '', '2015-09-05 11:30:07', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('9c8aa427-3253-41c9-af3b-b350b295d911', '', '2015-12-01 23:25:18', '购物-电缆线', '90', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('9fb2910c-823e-44f8-ad05-fc1e186bee3e', '', '2015-09-08 10:24:37', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('a07c76e5-e8de-4318-b574-56c8a997bd1e', '', '2015-11-28 00:40:12', '购物-电缆线', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('a0e6a5a2-dfc4-46eb-919e-bdb347f47dbf', '', '2015-09-25 10:49:33', '购物-齿轮盘', '120', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('a3d65027-87dc-4ddb-8af6-44f41a24e617', '', '2015-12-01 23:37:33', '购物-十芯插件', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('a5cdae06-f1da-45da-ba16-87a324ce03f0', '', '2015-09-22 22:35:32', '购物-齿轮盘,齿轮盘', '240', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('a7e235e1-6e1a-43bc-a47b-19da54dc07b7', '', '2015-11-12 15:25:45', '购物-提升机测试,测试', '46', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('a873548d-0ef7-4e8d-a50e-5cf403b74e31', '', '2015-10-25 12:18:32', '购物-CJX2交流接触器', '55', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('aa5384a4-3ad0-468a-80c6-8eba7fe27388', '', '2015-12-11 00:13:55', '购物-五芯工业插件', '49', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('b071a0d5-da0b-49bd-bdb3-5119b3aa09d1', '', '2015-11-18 10:02:40', '购物-提升机测试,CJX2交流接触器', '180', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('b6b09fe6-ba3b-4f8b-9692-49e3104a12f2', '', '2015-11-24 10:24:28', '购物-CJX2交流接触器', '45', '366e9a99-8147-4a33-9058-a58687890c09');
INSERT INTO `consumptionnote` VALUES ('b915b08b-e34f-4dee-8981-5a783b22a24d', '', '2015-11-27 00:40:01', '购物-摆臂', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('b9189856-249d-48b0-b00b-5ea15c4ed9bb', '', '2015-09-08 10:26:51', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('b923a987-fb2c-42b4-8ae7-265fe19cd40a', '', '2015-09-19 22:53:41', '购物-齿轮盘', '120', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('bc701b23-56f4-40b6-b016-538c77320a1b', '', '2015-11-18 23:04:35', '购物-压轮组件,提升机测试', '90.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('bce59ba1-b3ab-450c-8b19-a9257a9ae30a', '', '2015-11-19 21:42:54', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('bce638d6-18a0-4805-82f9-8eb3108b2ff9', '', '2015-11-26 17:00:41', '购物-摆臂,压轮组件', '90', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('be56bfaf-d7e5-4ce4-a5a1-499b77fb02b6', '', '2015-11-23 13:03:58', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('bfe1c5e3-6d7c-4fa7-ba90-a1260b718f99', '', '2015-11-14 14:38:01', '购物-测试', '0', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('c0b88a98-45c4-4373-bfda-803a4584268f', '', '2015-10-25 12:38:08', '购物-CJX2交流接触器,CJX2交流接触器', '165', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('c242ddcd-d62f-485c-8080-81fe29a17139', '', '2015-09-11 22:26:05', '购物-美妆2', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('c2d1bea3-43ec-49b4-8bd4-6d3047736941', '', '2015-09-29 22:17:04', '购物-齿轮盘', '120', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('c462dd44-d134-4785-b466-fcede9b23725', '', '2015-10-25 12:19:32', '购物-CJX2交流接触器,CJX2交流接触器', '110', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('c4c1a4bd-4a83-48e1-b20f-9a7a4c66aba7', '', '2015-12-07 16:52:19', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('c6d5afd9-5ef0-449d-893c-7e55e74d5627', '', '2015-12-06 22:39:21', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('c71225fc-0d7f-40e7-96e7-087faaca647e', '', '2015-12-06 23:43:04', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('c9a2b175-1171-447a-8331-4c3e43e8d1d5', '', '2015-09-22 22:48:10', '购物-涡轮,涡轮', '600', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('c9b5f4b0-be58-4f6b-8b73-72bb52e191c6', '', '2015-11-15 12:23:06', '购物-提升机测试', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('c9cdf140-5493-44f5-8374-2edd87855ae0', '', '2015-11-18 19:05:15', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('cb623cf6-f08b-47dc-9f00-fb333ec5c396', '', '2015-12-06 23:46:41', '购物-电缆线', '49', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('cbbf29e1-b301-466a-9ce0-5b9872c167b4', '', '2015-12-07 00:00:30', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('cc0e8995-b8f5-473a-b7bf-126c4d07ebc3', '', '2015-11-07 10:42:40', '购物-CJX2交流接触器', '3', '1f46314c-2fe9-4272-963b-4f2330c2daee');
INSERT INTO `consumptionnote` VALUES ('cde2b1c3-47ff-4674-9b48-6f15a9b5cddc', '', '2015-11-19 09:38:13', '购物-提升机测试', '0.9', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('d33eef7c-043b-4116-9e8d-708387890b4a', '', '2015-11-13 00:01:03', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('d4a3539d-ea5b-480a-8c19-9719c11c86e7', '', '2015-11-29 15:51:07', '购物-80提升机大齿轮', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('d693a087-10d1-4493-b3f6-cd4ba3234104', '', '2015-12-05 00:33:58', '购物-后支架', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('d6bda069-cf4c-4d47-a740-89d398d4d0ed', '', '2015-11-18 23:36:07', '购物-压轮组件', '180', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('d6f26c88-1501-4bf4-83d4-72ad1461aff3', '', '2015-09-05 11:23:25', '购物-美妆1,美妆2', '24', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('d86d1196-1da3-4045-9a75-8a6c0b959b4a', '', '2015-11-13 00:32:30', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('d8a3ca06-6764-42aa-b84b-9674ca7a4f79', '', '2015-11-29 12:28:02', '购物-电缆线', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('db084115-2f14-4abd-8eb1-ff981bbfeff2', '', '2015-12-09 00:05:45', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('dd233ab1-2644-4e89-91e4-ff540f192d9b', '', '2015-09-19 22:56:06', '购物-齿轮盘', '120', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('dea423d6-e441-4c63-ba1a-9cbdd2cf1ba0', '', '2015-11-29 14:08:08', '购物-80提升机大齿轮', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('df95e705-b824-4e99-9591-dbc6ef2a335b', '', '2015-11-29 14:32:58', '购物-十芯插件', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('e0b3a3b1-859b-4122-991c-1e259e23170f', '', '2015-09-08 14:49:58', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('e1f28fc7-911d-42a7-9f60-3593f7590414', '', '2015-11-10 15:02:29', '购物-CJX2交流接触器,测试', '90', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('e2d537da-e959-4f1b-9df1-56f6db281d90', '', '2015-11-27 00:47:48', '购物-摆臂', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('e36d3a2d-eba5-4aa8-838b-047c750deb32', '', '2015-11-18 23:48:59', '购物-压轮组件', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('e63d964b-03e4-4f26-9bee-7dbbc68795b6', '', '2015-12-05 01:05:58', '购物-摆臂', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('e6d37b5b-eb9e-4a00-9fb6-d148bd446a3b', '', '2015-12-01 23:34:30', '购物-十芯插件', '45', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('e863cf29-8f5e-4eea-9f5e-d502a2ddf453', '', '2015-09-21 12:17:01', '购物-齿轮盘', '120', 'bbacc27f-7d86-46a5-89e3-4a0f3020453e');
INSERT INTO `consumptionnote` VALUES ('e8b8b1f2-be4f-4e0f-91e1-dbdfd5fd1822', '', '2015-11-27 10:57:38', '购物-电缆线,80提升减速箱', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('ed9bee3b-b618-4068-a702-f3dc348d1b61', '', '2015-11-19 22:07:58', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('ee41c7b7-050a-4726-bb31-808550663fe3', '', '2015-11-13 00:28:56', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('ee514ec2-d90a-4e4a-a957-fd78977b1abc', '', '2015-11-07 15:56:32', '购物-CJX2交流接触器,测试', '7', '29591c2b-5c89-42c8-8cd4-175aeb78a60f');
INSERT INTO `consumptionnote` VALUES ('ee823840-d777-483a-8887-57ba99c2f27c', '', '2015-11-22 23:42:30', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('f1081b7d-d333-46a7-97fd-6a41158b6c70', '', '2015-09-05 11:24:40', '购物-美妆1', '12', '60ed6597-1993-47a3-8360-4096993799d6');
INSERT INTO `consumptionnote` VALUES ('f179705b-5249-45bc-99c2-1aab52958c75', '', '2015-11-29 15:36:43', '购物-电缆线', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('f29f9c8f-bd11-4069-b6fc-bb4fb438ff1e', '', '2015-11-01 22:20:00', '购物-测试', '100', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('f4464271-4a8e-4d58-aedd-61ed00840c29', '', '2015-11-04 12:05:40', '购物-测试', '100', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('f4a481b9-db5b-4d0d-ae46-8961e31104c4', '', '2015-11-21 15:31:20', '购物-提升机测试', '0.9', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('f57b4298-ad84-4410-af48-a45981b4a81d', '', '2015-12-04 00:19:03', '购物-电缆线', '49', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('f5c80d65-f00e-4458-81f0-a43c6d3ae82a', '', '2015-11-24 10:11:24', '购物-CJX2交流接触器,提升机测试', '52', '366e9a99-8147-4a33-9058-a58687890c09');
INSERT INTO `consumptionnote` VALUES ('f5db1c33-9e9b-4ea8-bdea-29b482a95ad7', '', '2015-11-13 00:34:02', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('f6bdc560-a8c8-4375-90ae-62bbcf85dada', '', '2015-11-15 11:22:27', '购物-测试', '0', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('f7077664-bee7-4ef9-bf6e-903071975d2f', '', '2015-11-26 16:55:15', '购物-绳轮', '45', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('f76e8a5f-c28a-4a4d-85fe-af382b2be2ac', '', '2015-11-19 16:29:44', '购物-提升机测试', '0.9', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('f7fcec20-2ad3-422e-8f92-291fa82b83fe', '', '2015-11-14 15:04:40', '购物-提升机测试', '45', '6ad19cc5-14a0-4743-ab88-4b3c10455703');
INSERT INTO `consumptionnote` VALUES ('f9958afe-2208-450d-b90b-bc2a67b31a5a', '', '2015-11-13 00:04:29', '购物-测试', '0', '577c8982-c23b-405a-b204-ee12bdde7c95');
INSERT INTO `consumptionnote` VALUES ('fb14308b-24cf-466f-87dc-c89bee14c5fb', '', '2015-11-29 15:23:14', '购物-电缆线', '90', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');
INSERT INTO `consumptionnote` VALUES ('fc187e6a-10be-43ea-9bdf-96f0771ea37c', '', '2015-12-01 20:43:25', '购物-摆臂', '50', '1bbd62df-d47a-4d65-99ed-41f16181684a');
INSERT INTO `consumptionnote` VALUES ('fe0b929f-daaf-464f-834e-4d995179cf45', '', '2015-11-27 11:05:06', '购物-电缆线', '45', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e');

-- ----------------------------
-- Table structure for expertsdesigninfo
-- ----------------------------
DROP TABLE IF EXISTS `expertsdesigninfo`;
CREATE TABLE `expertsdesigninfo` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `designcompanyname` varchar(100) DEFAULT NULL,
  `designcompanyaddr` varchar(100) DEFAULT NULL,
  `designenginename` varchar(100) DEFAULT NULL,
  `designengineaddr` varchar(100) DEFAULT NULL,
  `designgoodsname` varchar(100) DEFAULT NULL,
  `designgoodstype` varchar(100) DEFAULT NULL,
  `designtechnologyrequest` varchar(100) DEFAULT NULL,
  `designcompletedate` datetime DEFAULT NULL,
  `designapplicationdate` datetime DEFAULT NULL,
  `designlinkname` varchar(100) DEFAULT NULL,
  `designlinktel` varchar(100) DEFAULT NULL,
  `designemail` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of expertsdesigninfo
-- ----------------------------
INSERT INTO `expertsdesigninfo` VALUES ('066cd695-2b72-47ca-acd7-2bb72402e503', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '阴差阳错一次', '餐厅推出天', '天头疼他', '阴差阳错一次', '出现', '衬托出一场雨', '采用阴差阳错', '2015-12-12 00:00:00', '2015-10-12 00:00:00', '顶焦度计', '13455433333', '头发反反复复', '已处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('3dc7b356-eddf-4934-a59a-74b7e156d142', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '哥哥哥哥', '放放风', '反反复复', '天天体育', '富贵有余', '放哥哥一样', '服服帖帖', '2015-12-25 00:00:00', '2015-11-25 00:00:00', '改改改', '134555544444', '都放放风', '未处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('75287832-1617-488e-b523-182c35e7569b', 'admin', '1', '2', '3', '4', '5', '63', '7', '2015-09-10 00:00:00', '2015-10-01 00:00:00', '8', '9', '11', '未处理', '\0', '2015-09-13 12:23:26', 'admin', null);
INSERT INTO `expertsdesigninfo` VALUES ('7beaa2b2-f634-490b-858e-fd52b9df80b2', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '他抬头', '放放风', '他抬头', '天天有', 'vvgwew', '反反复复', '风风光光共同体', '2015-12-11 00:00:00', '2015-11-10 00:00:00', '往往会', '127273737377', '苏苏苏', '未处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('996bbafc-898b-4607-8500-599f2fa0b5fd', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '爸爸', '空军建军节', '喇叭', '啦啊啊啊啊啊', '啦啦操', '老K啦啊', null, '2015-07-04 00:00:00', '2015-08-04 00:00:00', '啦啦吧', '擦擦擦', '啦啊啊啊啊啊', '未处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('a8e9a2c5-8757-4528-ba93-ebe15709f411', '577c8982-c23b-405a-b204-ee12bdde7c95', 'h', 'h', null, 'hg', 'h', 'g', null, '2015-08-03 00:00:00', '2015-08-08 00:00:00', 'h', 'g', 'g', '未处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('bd4491bb-bf6b-4450-85e3-30c052101719', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '哥哥哥哥好', '各个公园', '好后悔过', '更呵护', '有意义', '改改改', '哥哥哥哥', '2015-12-31 00:00:00', '2015-11-21 00:00:00', '改改改', '发的地方', '的大动干戈', '未处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('bd535cf3-eec8-42ae-acff-2ed10243126f', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '哥哥哥哥好', '各个公园', '好后悔过', '更呵护', '有意义', '改改改', '哥哥哥哥', '2015-12-31 00:00:00', '2015-11-21 00:00:00', '改改改', '发的地方', '的大动干戈', '未处理', '\0', null, null, null);
INSERT INTO `expertsdesigninfo` VALUES ('c93d2cd9-2ed6-4420-a540-1e542780f94c', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '哥哥哥哥', '放放风', '反反复复', '天天体育', '富贵有余', '放哥哥一样', '服服帖帖', '2015-12-25 00:00:00', '2015-11-25 00:00:00', '改改改', '134555544444', '都放放风', '未处理', '\0', null, null, null);

-- ----------------------------
-- Table structure for expertsproofinfo
-- ----------------------------
DROP TABLE IF EXISTS `expertsproofinfo`;
CREATE TABLE `expertsproofinfo` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `proofcompanyname` varchar(100) DEFAULT NULL,
  `proofcompanyaddr` varchar(100) DEFAULT NULL,
  `proofnenginename` varchar(100) DEFAULT NULL,
  `proofnengineaddr` varchar(100) DEFAULT NULL,
  `proofdesigncompany` varchar(100) DEFAULT NULL,
  `proofgoodsname` varchar(100) DEFAULT NULL,
  `proofgoodstype` varchar(100) DEFAULT NULL,
  `prooftype` varchar(100) DEFAULT NULL,
  `proofplandate` datetime DEFAULT NULL,
  `proofapplicationdate` datetime DEFAULT NULL,
  `prooflinkname` varchar(100) DEFAULT NULL,
  `prooflinktel` varchar(100) DEFAULT NULL,
  `proofemail` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of expertsproofinfo
-- ----------------------------
INSERT INTO `expertsproofinfo` VALUES ('113c7637-90df-4786-90fb-9cd038ff4e67', 'admin', '1y', '', '', '', '', '', '', '', null, null, '19', '123', '', '未处理', '\0', '2015-09-18 18:17:13', 'admin', null);

-- ----------------------------
-- Table structure for expresscode
-- ----------------------------
DROP TABLE IF EXISTS `expresscode`;
CREATE TABLE `expresscode` (
  `Code` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Sort` int(11) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of expresscode
-- ----------------------------
INSERT INTO `expresscode` VALUES ('anxindakuaixi', '安信达', null);
INSERT INTO `expresscode` VALUES ('baifudongfang', '百福东方', null);
INSERT INTO `expresscode` VALUES ('bangsongwuliu', '邦送物流', null);
INSERT INTO `expresscode` VALUES ('chuanxiwuliu', '传喜物流', null);
INSERT INTO `expresscode` VALUES ('coe', '中国东方（COE）', null);
INSERT INTO `expresscode` VALUES ('datianwuliu', '大田物流', null);
INSERT INTO `expresscode` VALUES ('debangwuliu', '德邦物流', null);
INSERT INTO `expresscode` VALUES ('disifang', '递四方', null);
INSERT INTO `expresscode` VALUES ('dsukuaidi', 'D速快递', null);
INSERT INTO `expresscode` VALUES ('ems', 'EMS', null);
INSERT INTO `expresscode` VALUES ('feibaokuaidi', '飞豹快递', null);
INSERT INTO `expresscode` VALUES ('feikangda', '飞康达物流', null);
INSERT INTO `expresscode` VALUES ('feikuaida', '飞快达', null);
INSERT INTO `expresscode` VALUES ('fengxingtianxia', '风行天下', null);
INSERT INTO `expresscode` VALUES ('ganzhongnengda', '港中能达', null);
INSERT INTO `expresscode` VALUES ('gls', 'GLS', null);
INSERT INTO `expresscode` VALUES ('gongsuda', '共速达', null);
INSERT INTO `expresscode` VALUES ('guangdongyouzhengwuliu', '广东邮政', null);
INSERT INTO `expresscode` VALUES ('guotongkuaidi', '国通快递', null);
INSERT INTO `expresscode` VALUES ('haihongwangsong', '山东海红', null);
INSERT INTO `expresscode` VALUES ('haimengsudi', '海盟速递', null);
INSERT INTO `expresscode` VALUES ('hengluwuliu', '恒路物流', null);
INSERT INTO `expresscode` VALUES ('hkpost', '香港邮政', null);
INSERT INTO `expresscode` VALUES ('huaqikuaiyun', '华企快运', null);
INSERT INTO `expresscode` VALUES ('huaxialongwuliu', '华夏龙', null);
INSERT INTO `expresscode` VALUES ('huiqiangkuaidi', '汇强快递', null);
INSERT INTO `expresscode` VALUES ('huitongkuaidi', '百世汇通', null);
INSERT INTO `expresscode` VALUES ('jiajiwuliu', '佳吉物流', null);
INSERT INTO `expresscode` VALUES ('jialidatong', '嘉里大通', null);
INSERT INTO `expresscode` VALUES ('jiayiwuliu', '佳怡物流', null);
INSERT INTO `expresscode` VALUES ('jiayunmeiwuliu', '加运美', null);
INSERT INTO `expresscode` VALUES ('jietekuaidi', '捷特快递', null);
INSERT INTO `expresscode` VALUES ('jindawuliu', '金大物流', null);
INSERT INTO `expresscode` VALUES ('jinguangsudikuaijian', '京广速递', null);
INSERT INTO `expresscode` VALUES ('jinyuekuaidi', '晋越快递', null);
INSERT INTO `expresscode` VALUES ('jixianda', '急先达', null);
INSERT INTO `expresscode` VALUES ('kangliwuliu', '康力物流', null);
INSERT INTO `expresscode` VALUES ('kuaijiesudi', '快捷速递', null);
INSERT INTO `expresscode` VALUES ('kuayue', '跨越物流', null);
INSERT INTO `expresscode` VALUES ('lanbiaokuaidi', '蓝镖快递', null);
INSERT INTO `expresscode` VALUES ('lianbangkuaidi', '联邦快递', null);
INSERT INTO `expresscode` VALUES ('lianhaowuliu', '联昊通', null);
INSERT INTO `expresscode` VALUES ('longbanwuliu', '龙邦物流', null);
INSERT INTO `expresscode` VALUES ('longlangkuaidi', '隆浪快递', null);
INSERT INTO `expresscode` VALUES ('meiguokuaidi', '美国快递', null);
INSERT INTO `expresscode` VALUES ('menduimen', '门对门', null);
INSERT INTO `expresscode` VALUES ('mingliangwuliu', '明亮物流', null);
INSERT INTO `expresscode` VALUES ('neweggozzo', '新蛋奥硕物流', null);
INSERT INTO `expresscode` VALUES ('quanchenkuaidi', '全晨快递', null);
INSERT INTO `expresscode` VALUES ('quanfengkuaidi', '全峰快递', null);
INSERT INTO `expresscode` VALUES ('quanjitong', '全际通', null);
INSERT INTO `expresscode` VALUES ('quanritongkuaidi', '全日通', null);
INSERT INTO `expresscode` VALUES ('quanyikuaidi', '全一快递', null);
INSERT INTO `expresscode` VALUES ('rufengda', '凡客如风达', null);
INSERT INTO `expresscode` VALUES ('saiaodi', '赛澳递', null);
INSERT INTO `expresscode` VALUES ('santaisudi', '三态速递', null);
INSERT INTO `expresscode` VALUES ('sevendays', '七天连锁', null);
INSERT INTO `expresscode` VALUES ('shangda', '上大物流', null);
INSERT INTO `expresscode` VALUES ('shenganwuliu', '圣安物流', null);
INSERT INTO `expresscode` VALUES ('shengfengwuliu', '盛丰物流', null);
INSERT INTO `expresscode` VALUES ('shenghuiwuliu', '盛辉物流', null);
INSERT INTO `expresscode` VALUES ('shentong', '申通快递', null);
INSERT INTO `expresscode` VALUES ('shunfeng', '顺丰速递', null);
INSERT INTO `expresscode` VALUES ('suer', '速尔物流', null);
INSERT INTO `expresscode` VALUES ('suijiawuliu', '穗佳物流', null);
INSERT INTO `expresscode` VALUES ('sxhongmajia', '山西红马甲', null);
INSERT INTO `expresscode` VALUES ('tiandihuayu', '华宇物流', null);
INSERT INTO `expresscode` VALUES ('tiantian', '海航天天', null);
INSERT INTO `expresscode` VALUES ('tnt', 'TNT', null);
INSERT INTO `expresscode` VALUES ('tonghetianxia', '通和天下', null);
INSERT INTO `expresscode` VALUES ('ups', 'UPS', null);
INSERT INTO `expresscode` VALUES ('wanjiawuliu', '万家物流', null);
INSERT INTO `expresscode` VALUES ('wanxiangwuliu', '万象物流', null);
INSERT INTO `expresscode` VALUES ('weitepai', '微特派', null);
INSERT INTO `expresscode` VALUES ('xinbangwuliu', '新邦物流', null);
INSERT INTO `expresscode` VALUES ('xinfengwuliu', '信丰物流', null);
INSERT INTO `expresscode` VALUES ('yafengsudi', '亚风速递', null);
INSERT INTO `expresscode` VALUES ('yibangwuliu', '一邦速递', null);
INSERT INTO `expresscode` VALUES ('yinjiesudi', '银捷速递', null);
INSERT INTO `expresscode` VALUES ('yitongfeihong', '一统飞鸿', null);
INSERT INTO `expresscode` VALUES ('youshuwuliu', '优速物流', null);
INSERT INTO `expresscode` VALUES ('youzhengguonei', '邮政小包', null);
INSERT INTO `expresscode` VALUES ('yuananda', '源安达', null);
INSERT INTO `expresscode` VALUES ('yuanchengwuliu', '远成物流', null);
INSERT INTO `expresscode` VALUES ('yuanfeihangwuliu', '原飞航', null);
INSERT INTO `expresscode` VALUES ('yuantong', '圆通速递', null);
INSERT INTO `expresscode` VALUES ('yuanweifeng', '源伟丰快递', null);
INSERT INTO `expresscode` VALUES ('yuanzhijiecheng', '元智捷诚', null);
INSERT INTO `expresscode` VALUES ('yuefengwuliu', '越丰物流', null);
INSERT INTO `expresscode` VALUES ('yunda', '韵达快运', null);
INSERT INTO `expresscode` VALUES ('yuntongkuaidi', '运通快递', null);
INSERT INTO `expresscode` VALUES ('zhaijisong', '宅急送', null);
INSERT INTO `expresscode` VALUES ('zhengzhoujianhua', '郑州建华', null);
INSERT INTO `expresscode` VALUES ('zhimakaimen', '芝麻开门', null);
INSERT INTO `expresscode` VALUES ('zhongsukuaidi', '中速快件', null);
INSERT INTO `expresscode` VALUES ('zhongtianwanyun', '中天万运', null);
INSERT INTO `expresscode` VALUES ('zhongtong', '中通速递', null);
INSERT INTO `expresscode` VALUES ('zhongxinda', '忠信达快递', null);
INSERT INTO `expresscode` VALUES ('zhongyouwuliu', '中邮物流', null);

-- ----------------------------
-- Table structure for fault
-- ----------------------------
DROP TABLE IF EXISTS `fault`;
CREATE TABLE `fault` (
  `faultid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '新闻编号',
  `faulttitle` varchar(50) COLLATE utf8_bin NOT NULL COMMENT '新闻标题',
  `faultislogo` bit(1) NOT NULL COMMENT '新闻有预览图',
  `faultlogo` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '新闻url',
  `faultdate` datetime NOT NULL COMMENT '新闻发布时间',
  `faultsummary` varchar(500) COLLATE utf8_bin DEFAULT NULL COMMENT '新闻简介',
  `faultcontent` varchar(2000) COLLATE utf8_bin DEFAULT NULL COMMENT '新闻内容',
  `type1` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  `type2` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`faultid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of fault
-- ----------------------------
INSERT INTO `fault` VALUES ('19669537-f191-4ec8-9b8c-78c16309afbf', '有问题', '\0', null, '0001-01-01 00:00:00', '有问题有问题有问题', '有问题有问题有问题有问题有问题有问题', '00001', null);
INSERT INTO `fault` VALUES ('4310590d-dd08-4c71-a482-08c0c9822157', '800提升机清理保养', '', '/fileupload/fault/Original/1f81983b6bc5470aa0c57e0dea440d1c.jpg', '2016-02-19 00:00:00', '提升机的清理保养', '<p>\r\n	<img style=\"width:284px;height:184px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322085710_3570.jpg\" width=\"3225\" height=\"1988\" />&nbsp;&nbsp;&nbsp;&nbsp;<img style=\"width:285px;height:181px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322085953_2320.png\" width=\"288\" height=\"259\" /> \r\n</p>\r\n<img style=\"width:273px;height:190px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322090400_1070.png\" width=\"305\" height=\"234\" /> \r\n<p>\r\n	<img style=\"width:270px;height:192px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322090938_3570.png\" width=\"297\" height=\"259\" />&nbsp;&nbsp;<img style=\"width:271px;height:187px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322091255_4663.png\" width=\"325\" height=\"256\" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img style=\"width:272px;height:173px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322091412_4976.png\" width=\"268\" height=\"208\" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img style=\"width:268px;height:181px;\" alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322091528_8726.png\" width=\"274\" height=\"258\" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;\r\n</p>\r\n<p>\r\n	&nbsp;\r\n</p>', '00001', null);
INSERT INTO `fault` VALUES ('4fc13c7b-4c86-42a9-bb2a-9efb9457c844', '安全锁锁绳时打滑', '\0', null, '2015-11-05 00:00:00', '安全锁锁绳时打滑', '<p>\r\n	安全锁锁绳时打滑原因：\r\n</p>\r\n<p>\r\n	1.钢丝绳上有油\r\n</p>\r\n<p>\r\n	2.钢丝绳磨损过细\r\n</p>\r\n<p>\r\n	&nbsp;\r\n</p>', '00003', null);
INSERT INTO `fault` VALUES ('7f9c5203-8c06-4dca-87bd-a44ff109d6e2', '线路老化', '', '/fileupload/fault/Original/866f827a52814af899ea7ed83cab1e90.jpg', '2016-02-25 00:00:00', '重新接线', '<img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131109_3570.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131116_7320.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131224_9195.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131231_7007.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131238_2788.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131244_9507.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131251_4351.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131259_8413.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131306_2007.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131311_9820.jpg\" /> \r\n<p>\r\n	&nbsp;\r\n</p>', '00001', null);
INSERT INTO `fault` VALUES ('9006552e-b44f-431c-8bf4-74d1e5d8ca34', '提升机零部件磨损严重', '', '/fileupload/fault/Original/431e190026274b2bace8609464e479eb.jpg', '2016-03-18 00:00:00', '更换提升机零部件', '<img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322112827_4195.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322112836_3101.png\" /> <img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130635_4038.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130645_9351.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130652_7632.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130659_1851.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130710_6070.png\" /> \r\n<p>\r\n	<img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130726_0601.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130740_9976.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130751_8726.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130804_2476.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130818_1226.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130830_6695.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130839_6538.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130851_7476.png\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322130901_9507.png\" />&nbsp;\r\n</p>', '00001', null);
INSERT INTO `fault` VALUES ('c3a8bc6e-1b0c-40f0-9547-b91bb6451a03', '压盘磨损', '', '/fileupload/fault/Original/b857f9f33b0f4619a6d013fb87b125e9.jpg', '2016-03-22 00:00:00', '更换压盘', '<img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131829_7632.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131836_4976.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131844_0288.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131850_3726.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131856_7163.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131902_4820.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131908_8257.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131914_5445.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131921_5913.jpg\" /><img alt=\"\" src=\"/content/kindeditor/attached/image/20160322/20160322131927_2320.jpg\" /> \r\n<p>\r\n	&nbsp;\r\n</p>', '00001', null);

-- ----------------------------
-- Table structure for faulttype
-- ----------------------------
DROP TABLE IF EXISTS `faulttype`;
CREATE TABLE `faulttype` (
  `typeid` varchar(36) COLLATE utf8_bin NOT NULL,
  `typename` varchar(50) COLLATE utf8_bin NOT NULL,
  `typelogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `sort` int(11) NOT NULL,
  `Isshow` bit(1) NOT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `typeadimgurl` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `pid` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  `isPinPai` bit(1) DEFAULT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of faulttype
-- ----------------------------
INSERT INTO `faulttype` VALUES ('00001', '提升机部件', '/fileupload/fault/Original/edaabbdc08bf4a819106d3bd2c3cc890.png', '0', '\0', '1', '', '', '\0');
INSERT INTO `faulttype` VALUES ('0000100001', '配电箱部件', '/fileupload/fault/Original/828e642a4f474d7489ccdbac7ad95b97.png', '1', '\0', '11', '', '', '\0');
INSERT INTO `faulttype` VALUES ('00002', '安全锁部件', '/fileupload/fault/Original/3dc46d0edaec487b92351c5cca464e30.png', '3', '\0', '2', '', '', '\0');
INSERT INTO `faulttype` VALUES ('0000200001', '电缆', '/fileupload/fault/Original/04c25b4b327340f68a234f7f0a7874aa.png', '4', '\0', '22', '', '', '\0');
INSERT INTO `faulttype` VALUES ('00003', '钢丝绳', '/fileupload/fault/Original/4af710ee6bb7402ba8b0436416515516.png', '5', '\0', '3', '', '', '\0');
INSERT INTO `faulttype` VALUES ('000084eb-198a-4f35-bb8a-32ef886e5fe6', '十芯插件', '/fileupload/goods/Original/5f0e54a41df541c2929a2cf329ec284e.jpg', '0', '\0', '', null, '00003', '\0');
INSERT INTO `faulttype` VALUES ('0021876d-61ef-4e09-8861-7167c8844938', '航空插件', '/fileupload/goods/Original/4a2181b8b9ff4effbbf4446c28124976.jpg', '0', '\0', '', null, '00003', '\0');
INSERT INTO `faulttype` VALUES ('0dcb5861-1865-4b85-bda8-2a1e7f72bf4d', '提升机', '/fileupload/goods/Original/a7b9fa800e2547209b1cb776d0bcbc04.jpg', '1', '\0', '提升机', null, '00001', '\0');
INSERT INTO `faulttype` VALUES ('0eec627a-b912-4ed8-9694-8d63c2011558', '电器板', '/fileupload/goods/Original/2325a6b441da4f47a8b9914eb6f1f192.jpg', '0', '\0', '', null, '0000100001', '\0');
INSERT INTO `faulttype` VALUES ('0f224551-2076-4840-baeb-a490ec150b94', '五芯工业插件', '/fileupload/goods/Original/f02e4415833c4315ae0ef0c6a8507fc8.jpg', '0', '\0', '', null, '00003', '\0');
INSERT INTO `faulttype` VALUES ('1e2adb11-bf81-4ef7-9b36-e73851c4cf3a', '申锡', '/fileupload/goods/Original/e6c3f8f5a18b433896141d31512c80aa.jpg', '0', '\0', '', null, '0000100001', '');
INSERT INTO `faulttype` VALUES ('2f2289bf-5268-4b96-a9e8-2198b869cb90', '安装架', '/fileupload/goods/Original/990187d2c8834030b801a814df4c7035.jpg', '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `faulttype` VALUES ('3326de65-a862-4da4-b3fa-daee67003524', '吊船', '/fileupload/goods/Original/b72d2d6eae514d74975d1b386ccd6471.jpg', '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `faulttype` VALUES ('3b8f1a0a-d0eb-4d2b-bff8-682ab49a4bd6', '电缆线', '/fileupload/goods/Original/fd730c87d0a94c5a89a2250bdc705474.jpg', '0', '\0', '', null, '00003', '\0');
INSERT INTO `faulttype` VALUES ('3c659c76-bdd1-4ca9-8c22-737ab8efb727', '申锡', '/fileupload/goods/Original/e2095e98e6ee4614b0b34cffec495def.jpg', '0', '\0', '', null, '00003', '');
INSERT INTO `faulttype` VALUES ('3efc7c1e-0c17-4b1e-91c7-f5a5389a3b4c', '电机配件', '/fileupload/goods/Original/85336ea41b624f6590030d34753d3433.jpg', '4', '\0', '电机配件', null, '00001', '\0');
INSERT INTO `faulttype` VALUES ('40a76b4d-a1af-4d15-aac8-5871c12a8921', '变压器', '/fileupload/goods/Original/508c0c19e75644c68231177deae91916.jpg', '0', '\0', '', null, '0000300001', '\0');
INSERT INTO `faulttype` VALUES ('521d4ce7-b7da-4e7a-bbc3-5ebba649d7f8', '控制开关', '/fileupload/goods/Original/20e93661a953477daeb4f29150ee3297.jpg', '0', '\0', '', null, '0000300001', '\0');
INSERT INTO `faulttype` VALUES ('5f2ad4ab-3a0a-45aa-95ae-343c19a3dae9', '申锡', '/fileupload/goods/Original/258f452079544bc9b144ef2ad8f8b015.jpg', '0', '\0', '', null, '0000300001', '');
INSERT INTO `faulttype` VALUES ('78f915c6-1a9a-48db-a641-53b9bca9eb61', '控制手柄', '/fileupload/goods/Original/c00f5e9e2afc426eaf525c31f87bead4.jpg', '0', '\0', '', null, '0000100001', '\0');
INSERT INTO `faulttype` VALUES ('9615352b-14a3-423b-abca-b18ea3c4b475', '申锡', '/fileupload/goods/Original/791ae063f7d94d7996801bc7889d5ae1.jpg', '0', '\0', '', null, '00002', '');
INSERT INTO `faulttype` VALUES ('970a6d98-5cb3-4d05-86d5-32d43d539708', '提升机配件', '/fileupload/goods/Original/488b9ae14e3c491aaa2ce0810c5c422c.jpg', '3', '\0', '提升机配件', null, '00001', '\0');
INSERT INTO `faulttype` VALUES ('9721f2f1-02e0-4ad2-bb4b-67e1781f0ddc', '摆臂', '/fileupload/goods/Original/c0e25a83f4504dfabad214d7317ea227.jpg', '0', '\0', '', null, '00002', '\0');
INSERT INTO `faulttype` VALUES ('9e20398d-4fb5-479b-b36e-671128e5da86', '不锈钢电箱外壳', '/fileupload/goods/Original/3606015398dc47ee8ecad576385d7441.jpg', '0', '\0', '', null, '0000100001', '\0');
INSERT INTO `faulttype` VALUES ('a29721f9-71a3-4a5c-9b2c-0f25f2c4624b', '底板', '/fileupload/goods/Original/4ad8b3bbc53a446fb154b1561a2ee5bb.jpg', '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `faulttype` VALUES ('a4897d98-ec07-4945-b3a8-14cd17da2e20', '电机', '/fileupload/goods/Original/afa113770bf6499f965bf660cace7b23.jpg', '2', '\0', '电机', null, '00001', '\0');
INSERT INTO `faulttype` VALUES ('a541574d-1271-48d4-aff7-ef5a471ae23c', '绳夹', '/fileupload/goods/Original/3e6d1a4befa5436abad9381473d6bf37.jpg', '0', '\0', '', null, '00002', '\0');
INSERT INTO `faulttype` VALUES ('af7ffaaf-b99d-4fef-a834-1a8bbdc35979', '衬板', '/fileupload/goods/Original/48c06aba4b604489a99a1c158a381205.jpg', '0', '\0', '', null, '00002', '\0');
INSERT INTO `faulttype` VALUES ('b328331a-55ed-4aa7-822a-1f1d9a10c323', '申锡', '/fileupload/goods/Original/03ee9df4d97b47d5b905eefa5a944d7e.jpg', '0', '\0', '', null, '0000200001', '');
INSERT INTO `faulttype` VALUES ('c858f5c5-87b5-4cca-bb65-4efb61c53a80', '申锡', '/fileupload/goods/Original/3767ac24c0c74c289f45538eaabc7c7c.jpg', '0', '\0', '', null, '00001', '');
INSERT INTO `faulttype` VALUES ('dde57eca-305c-4208-aefb-0b0eeb8109f7', '骑墙码', '/fileupload/goods/Original/b401f71c814e4804a18dee63549328f3.jpg', '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `faulttype` VALUES ('f7bed1e9-97b6-4665-b197-4169c1ebd54a', '分绳块', '/fileupload/goods/Original/7190e24def6a4611ba47c3f948e2abc2.jpg', '0', '\0', '', null, '00001', '\0');

-- ----------------------------
-- Table structure for goods
-- ----------------------------
DROP TABLE IF EXISTS `goods`;
CREATE TABLE `goods` (
  `goodsid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '商品编号',
  `goodsname` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '商品名称',
  `goodslogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `goodsprice` double NOT NULL,
  `goodsdiscountprice` double NOT NULL,
  `goodstype` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '一个商品属于一个类别',
  `goodscount` int(11) NOT NULL,
  `goodscontent` text COLLATE utf8_bin,
  `clickcount` int(11) DEFAULT NULL,
  `buycount` int(11) DEFAULT NULL,
  `goodsPinPai` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  `goodsType2` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`goodsid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of goods
-- ----------------------------
INSERT INTO `goods` VALUES ('0b59aee8-f586-456b-a03f-ee23483e6cdc', '800提升机大齿轮', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303333315F393839322E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09E6ADA4E9BDBFE8BDAEE69D90E8B4A8E4B8BAEFBC88EFBC89E992A2E69D90EFBC8CE7BB8FE8BF87EFBC88EFBC89E5A484E79086EFBC8CE7A1ACE5BAA6E4B8BAEFBC88EFBC89EFBC8CE9BDBFE8BDAEE997B4E5AF86E5BAA6E4B8BAEFBC88EFBC89E38082E5B7A5E889BAE7B2BEE889AFEFBC8CE794A8E69699E7B2BEEFBC8CE8B4A8E4BF9DEFBC88EFBC89E5B9B40D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303335335F383935352E6A706722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '46', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '49f28e48-3f59-4ca1-880c-38f700658171');
INSERT INTO `goods` VALUES ('0c497af0-84d0-4282-a343-a8504f26f510', '提升机驱动轮', '/fileupload/goods/Original/223c3042c08b4ff6afa173f1f9d129fc.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313834385F323836312E6A706722202F3E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313835365F363239382E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E, '22', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('0e81b79c-230c-49e1-8f6d-d37c74340fb6', '小油封', '/fileupload/goods/Original/d8385f7749cf441ebf16ba6217bbd9a1.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E4234372A32352A373C7370616E3EE88090E6B2B9E88090E985B8EFBC8CE998B2E5B098E998B2E6B2B93C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323535385F353336312E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, '20', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('0ee8921c-a19f-45b0-b7cd-7d93d6af9227', '控制开关', '/fileupload/goods/Original/d872ec40d37642f0ac14427714de68e8.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A09E6ADA3E6B3B0204E50322D4253353432EFBC88E98791E5B19EEFBC89E380814E50322D42413331EFBC88E98791E5B19EEFBC890D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343133333232315F303230352E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136343032355F383235372E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, '0f5d06b7-6303-4ee1-bf84-62103c573279', 'ac3445d2-ceda-42b2-8989-675634d73ad2');
INSERT INTO `goods` VALUES ('12203f2a-395b-4f5f-af66-15419a96546f', '封盖', '/fileupload/goods/Original/61c1595a960647b59c0644bb9652dc73.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE5B0BCE9BE99E38081E58E8BE993B8E9939DEFBC8CE998B2E6BC8FE6B2B93C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323832385F323730352E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '2', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('136e30c6-ccfc-49fc-a997-512566f6af92', '吊板', '/fileupload/goods/Original/bfffc8e707ff4e39aa9fd36b91f24513.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323432385F333031372E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323433355F333438362E6A706722202F3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('185bba72-ada5-451d-b530-583736eeddbf', '上支架', '/fileupload/goods/Original/b3c4c6c967214c8fa9fb32aa99b082c9.jpg', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363130303234315F343538302E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E, null, null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('1a105494-3c60-464d-8c1e-b11dab7c389f', '低篮杆', '/fileupload/goods/Original/4aadced69d6a40d8aa9537b6ff2b3561.jpg', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039343334305F363435352E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('1b01e0af-1dfd-4d62-bea8-cfd6b8b6b857', '底板', '/fileupload/goods/Original/38e75f9ad2cc4201830132c11eed19e7.png', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039323732325F323534382E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('1e9a5f24-078c-4e22-937f-b936a70cbf08', '压轮组件', '/fileupload/goods/Original/b0c1f778b4bd44ada970825fbcf28a6a.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E343063723C7370616E3EE993B8E58E8BE8B083E8B4A8E6B0AEE58C96EFBC8CE992A2E4B89DE7BBB3E4BD9CE58A9BE4BBB6EFBC8CE998B2E6ADA2E992A2E4B89DE7BBB3E68993E6BB913C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323931335F313736372E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, '9', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('1fdd3b82-1c49-40b0-a58f-69f7f3f9bd24', '箱盖', '/fileupload/goods/Original/be660e6e41394fe59100a5bad21e7580.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE5878FE9809FE7AEB1E79B963C7370616E3E5A4C3130362D543C2F7370616E3E3C7370616E3EEFBC8CE59084E99BB6E983A8E4BBB6E79A84E69EB6E4BD93EFBC8CE695A3E783ADE5AF86E5B0813C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323335355F393236372E6A706722202F3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323430345F373534382E6A706722202F3E200D0A3C2F703E0D0A3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('2112ef9b-00ab-4372-9204-cb8c80125340', '限速制动器', '/fileupload/goods/Original/984a4751ae5148d3a1a65545ce274513.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E34353C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EEFBC833C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EEFBC8CE9948CEFBC8CE6898BE58AA8E6BB91E9998DE697B6E5878FE9809FE4BD9CE794A83C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132333235365F383031372E6A706722202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373130303730355F373934352E706E6722202F3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, '1', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('21f88282-25ff-42a4-a9a5-85042d433d5e', '手柄', '/fileupload/goods/Original/5639d80495f5495183743b37307838b2.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E312F323C7370616E3EE5AFB8E6B0B4E785A4E6B094E7AEA1EFBC8CE99580E9948CEFBC8CE690ACE8BF90E68896E5AE89E8A385E697B6E4BDBFE794A83C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313730305F333634322E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E, '1', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('25a296a9-4792-43f6-b7a3-2b33e298b1ef', '锚', '/fileupload/goods/Original/ac1d2d639a8f4e30a70f70f0794f0a48.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313231305F353637332E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E, '1', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('316c80c4-cffd-4285-b8ca-08c4e8bdf37b', '涡轮组件', '/fileupload/goods/Original/f02f8285cca44a8facb39bcdfd4b7250.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE4BCA0E58AA8E4BBB63C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323235385F303034382E6A706722202F3E266E6273703B3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C696D67207374796C653D2277696474683A33303770783B6865696768743A33303270783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373130303330365F363338322E706E67222077696474683D2233313422206865696768743D2233323022202F3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('34ebd155-0630-42dc-9e03-efbbc4d2efc0', '短衬套', '/fileupload/goods/Original/cc010150d6d54d4e823e9a4e3c244ba5.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE7B289E5A2A8E586B6E98791E99381E59FBAEFBC8CE5AE9AE4BD8DE4BD9CE794A83C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323533395F333438362E6A706722202F3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039343335325F393139352E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039343430395F323633322E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('3c4aa4b5-81b4-422a-9a0e-e35ff8a6b359', '变压器', '/fileupload/goods/Original/1ba905f498934e81b1f5573ed4e38435.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A094A424B332D35300D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343133323032355F373730352E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136333335325F393530372E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '6', null, '70fbd862-3839-437e-8d8c-8e1ae0b17d86', 'ac3445d2-ceda-42b2-8989-675634d73ad2');
INSERT INTO `goods` VALUES ('4793df4a-f08c-4c78-bf52-9c4fa6706ef2', '滚子', '/fileupload/goods/Original/bdd9c2ed2eef4f66917b32d32cbbfc4e.jpg', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09E697A0E7BC9DE7AEA1323023EFBC8CE9948CEFBC8CE5AFBCE59091E4BD9CE794A8E380820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343130303335335F393131312E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343130303430385F343432332E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A32363170783B6865696768743A31373770783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134333834365F353434352E706E67222077696474683D2233333522206865696768743D2232313422202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134333932325F363037302E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '4', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('4869aea0-5f75-4594-8eae-f02834bd6fa1', '涡杆', '/fileupload/goods/Original/f636a669157340668be8e0524c9585c9.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E333863726D6F414C413C7370616E3EE8B083E8B4A8E38081E6B0AEE58C96EFBC8CE4BCA0E58AA8E4BBB63C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323130385F343733362E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B3C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039353731385F393832302E706E6722202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A33323670783B6865696768743A32303170783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039353733325F343033382E706E67222077696474683D2234343122206865696768743D2232353022202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('50272614-b5b3-4932-9951-57397677c07e', '左盖板', '/fileupload/goods/Original/f2af4a9bc79d4576a21f0a46ee02d89a.jpg', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A0951323335E58E8BE993B8EFBC8CE9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323731375F303230352E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323732385F393432332E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A34343370783B6865696768743A32313170783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136323533385F313639352E706E67222077696474683D2238323522206865696768743D2234313022202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('540d6d23-60b8-4420-b6f3-dad9b84e2441', '大油封', '/fileupload/goods/Original/fd053fc7014943eca7beb8bd63d4f2ae.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E423233302A3230302A31353C7370616E3EE88090E6B2B9E38081E88090E985B8EFBC8CE998B2E5B098E694BEE6B2B9E380823C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131313732315F383739382E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('611c81bb-c59b-4a99-b2b6-171a48dd0cc6', '导绳座下盖极', '/fileupload/goods/Original/0825c44912cd4919ac0d44f002bb5186.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E513233353C7370616E3EE586B2E4BBB6EFBC8CE99580E9948CEFBC8CE5AFBCE59091E4BD9CE794A83C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323135345F393236372E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('621378de-220c-463a-a6c8-5722c02ee816', '箱体630', '/fileupload/goods/Original/cc52c204fede4038b017136f76f057b0.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E5A4C3130362D54313C7370616E3EEFBC8CE59084E99BB6E983A8E4BBB6E79A84E69EB6E4BD933C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323530365F373339322E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373130313035335F363533382E706E6722202F3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E200D0A3C703E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373130313130345F383235372E706E67222077696474683D2234343022206865696768743D2233323422202F3E0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B203C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373130313133355F363639352E706E6722202F3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, '4', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('63cdbb8a-aade-4be2-8497-cd3bed698e8c', '高篮杆', '/fileupload/goods/Original/9d42440d271040489b1cb36068d02165.jpg', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039353233305F353034382E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('691a4826-e75f-471d-ae95-2080c1efd07e', '方榫销轴', '/fileupload/goods/Original/0f83d76501534b52b38df4fa8cb953cc.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A09E4B88DE99488E992A2333034E380820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343039353935345F363134322E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A383270783B6865696768743A32363270783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134333235315F393832302E706E67222077696474683D22373422206865696768743D2234323522202F3E266E6273703B266E6273703B266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B266E6273703B266E6273703B266E6273703B203C696D67207374796C653D2277696474683A373970783B6865696768743A31393570783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134333333325F343530372E706E67222077696474683D22353522206865696768743D2232333822202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '2', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('6f35feff-584e-407f-905c-481832d7065c', '导绳座上盖极', '/fileupload/goods/Original/30f3d1b1ac274f559e1e23321a1499ae.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E513233353C7370616E3EE586B2E4BBB6EFBC8CE99580E9948CEFBC8CE5AFBCE59091E4BD9CE794A83C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131313835365F393538302E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '4', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('76efc442-b1b3-49f8-8a21-7d3ae682d067', '提升机压盘', '/fileupload/goods/Original/4f78e82218d74a6196f61cbff61611cf.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313933395F393839322E6A706722202F3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323030355F333031372E6A706722202F3E3C2F7370616E3E200D0A3C2F703E, '3', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('78135361-b7a5-4dc6-ad2c-660c05ef549a', '托座', '/fileupload/goods/Original/2c101c6bcb414a07adbae5d6550062ce.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A09343263726D6FE7B2BEE993B8EFBC8CE99580E9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323432365F373534382E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136303635385F393335312E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136303731335F313835312E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('80ea1447-232e-4ee2-84b2-78390d4aa5b8', '轴肩套', '/fileupload/goods/Original/d6a54e532b7c419383db6df3bb170995.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE696B9E7AEA13C7370616E3E32303C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EEFBC833C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EEFBC8CE9948CEFBC8CE5AE9AE4BD8D3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132333530325F333739382E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, '5', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('824cd8a2-528d-4f9a-b819-36c485a5a43e', '提升机电缆', '/fileupload/goods/Original/d5b4f1c6579c47eeb2371c45cec2b6b4.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A095943332A312E352B362A302E37350D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132333433375F353833302E706E6722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '70fbd862-3839-437e-8d8c-8e1ae0b17d86', 'c73a8d69-5bef-4132-8179-9112504e2216');
INSERT INTO `goods` VALUES ('8452b986-c7af-483e-9915-07fb8a82f41c', '电机端盖', '/fileupload/goods/Original/c7b6cd908fb14cc5b785f929912526c4.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE58E8BE993B8E9939DEFBC8CE998B2E99BA8E998B2E5B0983C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323334305F393236372E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('8906e628-2eb3-4157-838f-0db7d374d308', '小销', '/fileupload/goods/Original/0e8208b1062b416ab870e6ceac3c5f84.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A09343523E99580E9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323631395F393131312E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136323034355F343139352E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('8aa335d3-faad-4c74-9699-e988ab5d5c97', '套板', '/fileupload/goods/Original/66067a5436344e63957e80e6879a3663.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A0931372D34E7B2BEE993B80D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323331375F313736372E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A33353570783B6865696768743A31383970783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135353934375F333235372E706E67222077696474683D2233353622206865696768743D2231373622202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A32323370783B6865696768743A33353170783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136303032315F373934352E706E67222077696474683D2232323922206865696768743D2234373522202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '2', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('8af5a963-8a1d-4c63-ad18-f6e93d7887bc', '安全锁绳口', '/fileupload/goods/Original/154f409454774a58a59418fb719510c1.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A09266E6273703B266E6273703B266E6273703B20343523E99580E9948CEFBC8CE5AFBCE59091E4BD9CE794A8E380820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343039353630365F373836312E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134303633365F353735372E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134303635385F343335312E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('92c803b8-f64b-4781-91c6-5e5bd734d092', '安装架', '/fileupload/goods/Original/3b728e55c95a43e594eedb0c2b2180fe.jpg', '8000', '8000', '0000200001', '500', 0x3C703E0D0A0951323335EFBC8CE7848AE7AEA134302A36302A32EFBC8CE783ADE9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039313133365F363932332E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039313134385F363631312E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '5', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('967d6bc8-34b8-47cd-9ffb-aa276b692b21', '绳轮', '/fileupload/goods/Original/79f636591f654e5ea94b943975aa3f37.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D226C656674223E0D0A09E993B8E58E8B34306372E8B083E8B4A8E6B0AEE58C96EFBC8CE4BCA0E58AA8EFBC8CE5AFBCE7BBB30D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313432375F353034382E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A34333070783B6865696768743A32343070783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039343930365F303238382E6A7067222077696474683D2238313322206865696768743D2234353522202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E, '1', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('9ca5900a-57ab-4bd1-8ffc-dc580b8d9063', '航空插件', '/fileupload/goods/Original/9eb1ee6cd6d14f6c8c9c727345843fc7.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A095253353135E380815053433231350D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132323934345F333031372E706E6722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136353031345F323738382E706E6722202F3E0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '19', null, '70fbd862-3839-437e-8d8c-8e1ae0b17d86', 'c73a8d69-5bef-4132-8179-9112504e2216');
INSERT INTO `goods` VALUES ('9d8493a6-3062-4b20-bd73-ebb828a9f189', '绳夹', '/fileupload/goods/Original/672c2df2d207496cab3e7c17dcb036e0.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A0931372D34E7B2BEE993B8EFBC8CE6B0AEE58C960D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323032305F383333302E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A33353370783B6865696768743A32343470783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135333632335F323738382E706E67222077696474683D2234313522206865696768743D2232373022202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A33373070783B6865696768743A32343170783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135343335395F333537302E706E67222077696474683D2233393822206865696768743D2232353122202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('a3213e9a-8b50-4e13-9642-1da73a65054a', '夹绳弹簧', '/fileupload/goods/Original/59b57b54dc074125bc02e6724a633e2d.png', '8000', '8000', '00002', '500', 0x3C703E0D0A0936305369324D6E412CE99580E9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343130333430365F323339322E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A31303170783B6865696768743A33333270783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134353234345F363835312E706E67222077696474683D2231313222206865696768743D2234303522202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A31343870783B6865696768743A32373670783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134353334385F373437362E706E67222077696474683D2231343422206865696768743D2232393422202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('ac0fe116-dde9-414a-a924-4bed0c5ace67', '风叶', '/fileupload/goods/Original/5d5a0173738e43db8260994577b5eb23.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE5A191E69699EFBC8CE695A3E783AD3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323733335F373730352E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('ac756536-2ccc-427f-94b1-49223ccede6e', '收绳器固定套', '/fileupload/goods/Original/e34a9b3450d84df2b0ea85b2a4a2b29e.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313532305F303230352E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313533325F303230352E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('af29c0fc-fee1-4022-9f46-e6cd3c5e7372', '电器板', '/fileupload/goods/Original/9af7c7828ac744359c930c0ba6ad5c5d.png', '8000', '8000', '0000100001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132343935375F383333302E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E, '10', null, '88d282f1-a198-4755-a569-50fffc2301bd', 'ca4a2071-3541-4f8c-92d1-48bb7690eff4');
INSERT INTO `goods` VALUES ('af928b4e-e1f2-4f37-b76a-d7d0127c5851', '630提升机压轮', '/fileupload/goods/Original/6d5c4b68f0ce40ec86a5f14d23865611.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303633365F353336312E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303634375F333634322E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('b34a8822-f6f3-4e2d-aa42-c6d746931adb', '连板', '/fileupload/goods/Original/e229916faa5042cfab38ce1a1b245275.png', '8000', '8000', '00002', '500', 0x3C703E0D0A0951323335E586B2E4BBB6EFBC8CE9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131313931395F363631312E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135333130385F323437362E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A32373170783B6865696768743A32343970783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135333133315F303238382E706E67222077696474683D2232373322206865696768743D2232353922202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('b7ae0a8c-68d9-4c0c-9541-28a567b00601', '靠绳轮', '/fileupload/goods/Original/117052a2d478472f8ce2451d356ba58d.png', '8000', '8000', '00002', '500', 0x3C703E0D0A0934306372E6B0AEE58C960D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343130333933335F323038302E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A32343070783B6865696768743A32323770783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135313833395F323030372E706E67222077696474683D2232383122206865696768743D2233323422202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A33303870783B6865696768743A32373170783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363135313934335F303931332E706E67222077696474683D2234333122206865696768743D2234353222202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('bb9fa915-1521-41d5-8e7a-4fcc05c1bf6f', '骑墙码', '/fileupload/goods/Original/088501517d19452194274175681c2c46.png', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363130303134315F353531372E706E6722202F3E200D0A3C2F703E, '1', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '7c1138cd-d5cf-49d5-92be-3979797f0817');
INSERT INTO `goods` VALUES ('c1f969a2-f06c-4713-ab5e-5788b41a93d8', '涡轮', '/fileupload/goods/Original/45eef69353c04d3ab5f69e9d2d5b6a48.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E5A514149392D343C7370616E3EE993B8E980A0E99D92E9939CEFBC8CE4BCA0E58AA8E4BBB63C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132323231325F353230352E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B3C2F7370616E3E3C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039353934395F343636332E706E6722202F3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E0D0A3C2F703E0D0A3C2F7370616E3E3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C2F7370616E3E200D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('c3ea23da-d482-4e05-b50a-c6119b2c2f68', '五芯工业插件', '/fileupload/goods/Original/0bb615b4a4b04c9ba0f14dea7251234e.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A095032304B47512D350D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132333633345F353531372E706E6722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136353235385F383130312E706E6722202F3E0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '29', null, '70fbd862-3839-437e-8d8c-8e1ae0b17d86', 'c73a8d69-5bef-4132-8179-9112504e2216');
INSERT INTO `goods` VALUES ('c49025d1-98dc-4ca5-b4d0-3b5fda74f3bf', '吊船', '/fileupload/goods/Original/83b796ae67e24ccdb0de2eb0b02c4b97.jpg', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D226C656674223E0D0A09E585A8E9939DE59088E987914C4436303633EFBC8CE596B7E5A191E380820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039323931375F323339322E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '1', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('c520a7be-7d62-4ebf-a778-7fbd174a2818', '不锈钢电箱外壳', '/fileupload/goods/Original/543770e3ec0c409e898e3e2b50154efe.png', '8000', '8000', '0000100001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132343930395F313631312E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A34383570783B6865696768743A33323170783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373038353931345F373136332E6A7067222077696474683D2236313522206865696768743D2234323822202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E, '10', null, '88d282f1-a198-4755-a569-50fffc2301bd', '9939877c-9fe2-4dde-8468-39007df44ab5');
INSERT INTO `goods` VALUES ('c6763fb2-5382-432f-9fac-d20d7d4aa679', '提升机齿轴', '/fileupload/goods/Original/35bf80feba6c4540a8fd7046c395bcf2.jpg', '8000', '8000', '00001', '500', 0x3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313735375F383739382E6A706722202F3E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313830345F303034382E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('c71ec3cf-82c4-4acd-8409-3f3da6a5ee78', '齿轮盘', '/fileupload/goods/Original/3d0c162f594f43c28cc44d8b5ed4a3aa.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D226C656674223E0D0A09333863726D6F414C41E8B083E8B4A8E38081E6B0AEE58C96EFBC8CE4BCA0E58AA8E4BBB6E380820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303934365F323233362E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039333235375F313037302E706E67222077696474683D2233333122206865696768743D2232343422202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039333331375F363533382E706E67222077696474683D2233323322206865696768743D2232333722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('cebde7e5-4087-4a52-b5af-1db8450494d6', '800提升减速箱', '/fileupload/goods/Original/b36fc7a1d71a4c82a86db3570b41b63c.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303531325F313736372E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131303532325F333031372E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '2', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '49f28e48-3f59-4ca1-880c-38f700658171');
INSERT INTO `goods` VALUES ('d4fa88f0-570f-4fb3-bf33-eeabd0ca50c0', '挡圈', '/fileupload/goods/Original/ab83dbddc01a4de59953ad892f4377ef.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E513233353C7370616E3EE99580E9948CEFBC8CE5AFBCE59091E4BD9CE794A83C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131313831315F373038302E6A706722202F3E200D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('dd0e3920-ab12-4879-9bbd-6c85c5897c63', '分绳块', '/fileupload/goods/Original/73e8505ffb9d47068a99b61ec9aadfb0.jpg', '8000', '8000', '00001', '500', 0x3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E200D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE7B2BEE993B83C7370616E3E31372D343C2F7370616E3E3C7370616E3EEFBC8CE58886E7BBB3E38081E5AFBCE59091E4BD9CE794A83C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131323633375F303531372E6A706722202F3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039343534345F333235372E706E67222077696474683D2233353622206865696768743D2232393122202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039343630345F303931332E706E6722202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E3C212D2D456E64467261676D656E742D2D3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('e802a249-e41c-4392-8c79-a7fb43d427ff', '十芯插件', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A095033322D3130E7B297E58D81E88AAF0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132333331375F313239382E706E6722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '50', null, '70fbd862-3839-437e-8d8c-8e1ae0b17d86', 'c73a8d69-5bef-4132-8179-9112504e2216');
INSERT INTO `goods` VALUES ('ec66d531-8dc6-474d-9a2a-7b9ab2ab194b', '摆臂', '/fileupload/goods/Original/3297ce20f5d34b2fa683229ecba88882.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A0951323335E586B2E4BBB6E99580E9948CE380820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343039353832335F373233362E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A33343570783B6865696768743A31373670783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134323134305F393636332E706E67222077696474683D2233393622206865696768743D2231393822202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '14', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('f0b6523d-09ea-493c-9f67-09533ce586c3', '进绳管', '/fileupload/goods/Original/84bb4bc44f2342bca0813b31f81d3c05.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D226C656674223E0D0A09E697A0E7BC9DE7AEA1EFBC88E586B7E8BDA7EFBC89EFBC8CE99580E9948CEFBC8CE5AFBCE992A2E4B89DE7BBB30D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363132313132365F323534382E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E, '2', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('f3adad39-3c5e-45c7-8d61-1a74462db0fd', '电缆线', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '8000', '8000', 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '500', 0x3C703E0D0A095943332A312E352B322A31EFBC8CE5B882E794B5E7BABFE58E820D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132352F32303135313132353132323834335F303833302E706E6722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '147', null, '15f9b539-d56b-4efd-845d-3a137a4b625e', 'c73a8d69-5bef-4132-8179-9112504e2216');
INSERT INTO `goods` VALUES ('f4b8ccc7-cf6c-48ac-908c-7f5f45a93ee9', '出绳管', '/fileupload/goods/Original/33f267791bb24d379422f3c742234955.jpg', '8000', '8000', '00001', '500', 0x3C7020616C69676E3D226C656674223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223EE697A0E7BC9DE7AEA13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223ECEA63C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E31382A333C7370616E3EE99580E9948CEFBC8CE794A8E4BA8EE5AFBCE587BAE992A2E4B89DE7BBB3E380823C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A6E6F726D616C3B223E3C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363131313535335F383634322E6A706722202F3E3C7370616E3E3C2F7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039333931325F373934352E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331372F32303136303331373039333933385F303630312E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '2', null, 'a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '46431531-9919-4ff7-8105-02ab0614d2ba');
INSERT INTO `goods` VALUES ('f790752c-aa1d-451b-849e-8886c6a99a4f', '管座', '/fileupload/goods/Original/aeb39bb09c944fe6a7bfa59a4dbfdde6.jpg', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039323633335F313134322E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '5', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('fefcd0fa-fbc2-487b-96d1-d68eaaa9a961', '后支架', '/fileupload/goods/Original/0225366db44f4082b98439fcd904ea3f.jpg', '8000', '8000', '0000200001', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132362F32303135313132363039353334345F343432332E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '16', null, '7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '86f60496-c477-4e65-bf17-c9ed1fc549b8');
INSERT INTO `goods` VALUES ('ff2b9c26-375e-4e47-a1af-1d6d0ae2f26b', '销', '/fileupload/goods/Original/2aef94b82e344f449560c5deb33634ff.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D226C656674223E0D0A09343523E99580E9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323533335F363134322E706E6722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136313931365F323934352E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363136313933335F383235372E706E6722202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D226C656674223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, null, null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('ff351434-2457-4e41-84a8-41285ec248cb', '方孔衬圈', '/fileupload/goods/Original/b031705b19794e6b9a13a1f665459dbe.jpg', '8000', '8000', '00002', '500', 0x3C703E0D0A09E4B88DE993B8E992A23330340D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343130333131385F343236372E6A706722202F3E200D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134323633355F363338322E706E67222077696474683D2232323622206865696768743D2232333922202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D67207374796C653D2277696474683A32313270783B6865696768743A31373870783B2220616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303136303331362F32303136303331363134323635325F333235372E706E67222077696474683D2232313322206865696768743D2231393322202F3E0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '8', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');
INSERT INTO `goods` VALUES ('ffaa0937-f5e3-4e5f-868d-2578c575823d', '双头螺锁', '/fileupload/goods/Original/eec642bffcd14f0ea5e3f8789b02e0fe.png', '8000', '8000', '00002', '500', 0x3C7020616C69676E3D2263656E746572223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A0951323335E99580E9948C0D0A3C2F703E0D0A3C7020616C69676E3D2263656E746572223E0D0A093C696D6720616C743D2222207372633D222F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313132342F32303135313132343131323133315F303833302E706E6722202F3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '5', null, '9515dca9-26fd-4ef8-990d-56cf1c6d58f4', 'c13519a0-77c2-4534-ac78-732688b3a3ab');

-- ----------------------------
-- Table structure for goodstype
-- ----------------------------
DROP TABLE IF EXISTS `goodstype`;
CREATE TABLE `goodstype` (
  `typeid` varchar(36) COLLATE utf8_bin NOT NULL,
  `typename` varchar(50) COLLATE utf8_bin NOT NULL,
  `typelogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `sort` int(11) NOT NULL,
  `Isshow` bit(1) NOT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `typeadimgurl` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `pid` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  `isPinPai` bit(1) DEFAULT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of goodstype
-- ----------------------------
INSERT INTO `goodstype` VALUES ('00001', '提升机', '/fileupload/goodstype/Original/dbc28449b1c242faa281a45373b5372d.png', '0', '\0', '1', '/fileupload/ad/Original/5335518eb0b54fc7bf0880e41acb4426.JPG', null, null);
INSERT INTO `goodstype` VALUES ('0000100001', '吊篮电箱', '/fileupload/goodstype/Original/3e4a157d10f745b993d8c7ee8e8d0ce7.png', '0', '\0', '11', '/fileupload/ad/Original/efd2b5709d694ae19991ce778de73427.JPG', null, null);
INSERT INTO `goodstype` VALUES ('00002', '安全锁', '/fileupload/goodstype/Original/a7f5874da55c48df9a695e6fdbc59352.png', '0', '\0', '2', '/fileupload/ad/Original/d2614761398842be9d5ca344f9130300.JPG', null, null);
INSERT INTO `goodstype` VALUES ('0000200001', '钢结构', '/fileupload/goodstype/Original/8ada5b5878d84854b8eca913150f40a8.png', '0', '\0', '22', '/fileupload/ad/Original/f622312f869a42fb883b90012a36a06f.JPG', null, null);
INSERT INTO `goodstype` VALUES ('0f5d06b7-6303-4ee1-bf84-62103c573279', '正泰', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '');
INSERT INTO `goodstype` VALUES ('15dcef4d-3257-4408-a397-3d29c5fb3148', '电机', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '\0');
INSERT INTO `goodstype` VALUES ('15f9b539-d56b-4efd-845d-3a137a4b625e', '无锡市电线厂', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '');
INSERT INTO `goodstype` VALUES ('40a76b4d-a1af-4d15-aac8-5871c12a8921', '变压器', '/fileupload/goods/Original/508c0c19e75644c68231177deae91916.jpg', '0', '\0', '', null, '0000300001', '\0');
INSERT INTO `goodstype` VALUES ('46431531-9919-4ff7-8105-02ab0614d2ba', '630型提升机配件', '/fileupload/goodstype/Original/1c425086eeb747a4a2a170178605bf0f.png', '0', '\0', '', null, '00001', '\0');
INSERT INTO `goodstype` VALUES ('49f28e48-3f59-4ca1-880c-38f700658171', '800型提升机配件', '/fileupload/goodstype/Original/a6c5c8eb65724e38abffe15afc05546a.png', '0', '\0', '', null, '00001', '\0');
INSERT INTO `goodstype` VALUES ('521d4ce7-b7da-4e7a-bbc3-5ebba649d7f8', '控制开关', '/fileupload/goods/Original/20e93661a953477daeb4f29150ee3297.jpg', '0', '\0', '', null, '0000300001', '\0');
INSERT INTO `goodstype` VALUES ('5f2ad4ab-3a0a-45aa-95ae-343c19a3dae9', '申锡', '/fileupload/goods/Original/258f452079544bc9b144ef2ad8f8b015.jpg', '0', '\0', '', null, '0000300001', '');
INSERT INTO `goodstype` VALUES ('638c150f-3599-4518-b0c9-135df601ba03', '安全绳', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '\0');
INSERT INTO `goodstype` VALUES ('70fbd862-3839-437e-8d8c-8e1ae0b17d86', '申锡', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '');
INSERT INTO `goodstype` VALUES ('75ffd27b-85c7-492c-a00e-52ed83005317', '800型提升机', '/fileupload/goodstype/Original/90c4d50b8a314cea89115f8f3f19d9fc.png', '0', '\0', '', null, '00001', '\0');
INSERT INTO `goodstype` VALUES ('7c1138cd-d5cf-49d5-92be-3979797f0817', '悬挂机构', null, '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `goodstype` VALUES ('7d8bf4d2-de89-4e2a-a877-d5bf0d47631d', '申锡', null, '0', '\0', '', null, '0000200001', '');
INSERT INTO `goodstype` VALUES ('86f60496-c477-4e65-bf17-c9ed1fc549b8', '整体钢结构', null, '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `goodstype` VALUES ('88d282f1-a198-4755-a569-50fffc2301bd', '申锡', null, '0', '\0', '', null, '0000100001', '');
INSERT INTO `goodstype` VALUES ('9515dca9-26fd-4ef8-990d-56cf1c6d58f4', '申锡', null, '0', '\0', '', null, '00002', '');
INSERT INTO `goodstype` VALUES ('9939877c-9fe2-4dde-8468-39007df44ab5', '电箱外壳', null, '0', '\0', '', null, '0000100001', '\0');
INSERT INTO `goodstype` VALUES ('a4c7e88c-27f5-4a2f-ad33-42f2f1000ed6', '申锡', '/fileupload/goodstype/Original/847cffc4fab04a469399c3ee3c813f2b.png', '0', '\0', '', null, '00001', '');
INSERT INTO `goodstype` VALUES ('ac3445d2-ceda-42b2-8989-675634d73ad2', '电机配件', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '\0');
INSERT INTO `goodstype` VALUES ('bb77db75-d380-4838-b889-bc7a80787ea5', '630型提升机', null, '0', '\0', '', null, '00001', '\0');
INSERT INTO `goodstype` VALUES ('bd433c4b-ef76-4e48-bb2f-01e1c37529cb', '篮体机构', null, '0', '\0', '', null, '0000200001', '\0');
INSERT INTO `goodstype` VALUES ('bf5ddd95-3488-484a-9eb0-3db812243b85', '整体电箱', null, '0', '\0', '', null, '0000100001', '\0');
INSERT INTO `goodstype` VALUES ('c13519a0-77c2-4534-ac78-732688b3a3ab', '安全锁配件', null, '0', '\0', '', null, '00002', '\0');
INSERT INTO `goodstype` VALUES ('c2c1a689-0f76-42ab-a54e-1038e64a0b02', '电机电缆安全绳', null, '0', '\0', '', null, null, '\0');
INSERT INTO `goodstype` VALUES ('c73a8d69-5bef-4132-8179-9112504e2216', '电缆', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '\0');
INSERT INTO `goodstype` VALUES ('ca4a2071-3541-4f8c-92d1-48bb7690eff4', '电箱配件', null, '0', '\0', '', null, '0000100001', '\0');
INSERT INTO `goodstype` VALUES ('d01c4cfe-8682-4173-b122-d198af28b50a', '自锁器', null, '0', '\0', '', null, 'c2c1a689-0f76-42ab-a54e-1038e64a0b02', '\0');
INSERT INTO `goodstype` VALUES ('e302debd-4f7b-4c4b-a908-db5829ebb0f2', '安全锁', null, '0', '\0', '', null, '00002', '\0');
INSERT INTO `goodstype` VALUES ('ff75aaa6-f422-49a1-82fa-e90e5629986d', 'CJX1交流接触器', '/fileupload/goods/Original/11d5f66cdf1c4195b321a0ad340cfca6.jpg', '0', '\0', '', null, '0000300001', '\0');

-- ----------------------------
-- Table structure for grade
-- ----------------------------
DROP TABLE IF EXISTS `grade`;
CREATE TABLE `grade` (
  `gradeid` varchar(36) COLLATE utf8_bin NOT NULL,
  `gradename` varchar(50) COLLATE utf8_bin NOT NULL,
  `gradelogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `gradefull` double NOT NULL,
  `gradediscount` double NOT NULL,
  PRIMARY KEY (`gradeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of grade
-- ----------------------------
INSERT INTO `grade` VALUES ('1eec78a5-f3f5-475f-bc32-06fe23c434fa', '铜牌会员', null, '10', '0.98');
INSERT INTO `grade` VALUES ('8dfa10a3-fdd3-4a78-89f7-28af9996388c', '普通会员', null, '0', '1');

-- ----------------------------
-- Table structure for jsj_keep
-- ----------------------------
DROP TABLE IF EXISTS `jsj_keep`;
CREATE TABLE `jsj_keep` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `GCMC` text COMMENT '工程名称',
  `XMDZ` text COMMENT '项目地址',
  `SBCQDW` text COMMENT '设备产权单位',
  `CQDWFZRJDH` text COMMENT '产权单位负责人及电话',
  `AZDW` text COMMENT '安装单位',
  `SBZZDW` text COMMENT '设备制造单位',
  `ZZDJ` text COMMENT '资质等级',
  `ZZBH` text COMMENT '资质编号',
  `SBXH` text COMMENT '设备型号',
  `SBJJH` text COMMENT '设备建鉴号',
  `ZMWJJYJG` text COMMENT '证明文件检验结果',
  `ZMWJJL` text COMMENT '证明文件结论',
  `ZMWJBZ` text COMMENT '证明文件备注',
  `CQZMJYJG` text COMMENT '产权证明检验结果',
  `CQZMJL` text COMMENT '产权证明结论',
  `CQZMBZ` text COMMENT '产权证明备注',
  `ZZZSJYJG` text COMMENT '资质证书检验结果',
  `ZZZSJL` text COMMENT '资质证书结论',
  `ZZZSBZ` text COMMENT '资质证书备注',
  `SYSMSJYJG` text COMMENT '使用说明书检验结果',
  `SYSMSJL` text COMMENT '使用说明书结论',
  `SYSMSBZ` text COMMENT '使用说明书备注',
  `GQDBZJZBSJYJG` text COMMENT '高强度标准件质保书检验结果',
  `GQDBZJZBSJL` text COMMENT '高强度标准件质保书结论',
  `GQDBZJZBSBZ` text COMMENT '高强度标准件质保书备注',
  `ZYSLGJCZZMJYJG` text COMMENT '主要受力构件材质证明检验结果',
  `ZYSLGJCZZMJL` text COMMENT '主要受力构件材质证明结论',
  `ZYSLGJCZZMBZ` text COMMENT '主要受力构件材质证明备注',
  `ZCBYJLJYJG` text COMMENT '转场保养记录检验结果',
  `ZCBYJLJL` text COMMENT '转场保养记录结论',
  `ZCBYJLBZ` text COMMENT '转场保养记录备注',
  `ZYJGJJYJG` text COMMENT '主要结构件检验结果',
  `ZYJGJJL` text COMMENT '主要结构件结论',
  `ZYJGJBZ` text COMMENT '主要结构件备注',
  `ZYSLGJJYJG` text COMMENT '主要受力构件检验结果',
  `ZYSLGJJL` text COMMENT '主要受力构件结论',
  `ZYSLGJBZ` text COMMENT '主要受力构件备注',
  `ZJSXXJYJG` text COMMENT '桁架上下弦检验结果',
  `ZJSXXJL` text COMMENT '桁架上下弦结论',
  `ZJSXXBZ` text COMMENT '桁架上下弦备注',
  `FGSXXJYJG` text COMMENT '腹杆上下弦检验结果',
  `FGSXXJL` text COMMENT '腹杆上下弦结论',
  `FGSXXBZ` text COMMENT '腹杆上下弦备注',
  `DGPZZXDJYJG` text COMMENT '导轨平直直线度检验结果',
  `DGPZZXDJL` text COMMENT '导轨平直直线度结论',
  `DGPZZXDBZ` text COMMENT '导轨平直直线度备注',
  `DGBMWHJYJG` text COMMENT '导轨表面完好检验结果',
  `DGBMWHJL` text COMMENT '导轨表面完好结论',
  `DGBMWHBZ` text COMMENT '导轨表面完好备注',
  `FQZZDXJGJYJG` text COMMENT '附墙支座导向结构检验结果',
  `FQZZDXJGJL` text COMMENT '附墙支座导向结构结论',
  `FQZZDXJGBZ` text COMMENT '附墙支座导向结构备注',
  `FQZZSFQJGJYJG` text COMMENT '附墙支座上防倾结构检验结果',
  `FQZZSFQJGJL` text COMMENT '附墙支座上防倾结构结论',
  `FQZZSFQJGBZ` text COMMENT '附墙支座上防倾结构备注',
  `FQZZFZLJGJYJG` text COMMENT '附墙支座防坠落结构检验结果',
  `FQZZFZLJGJL` text COMMENT '附墙支座防坠落结构结论',
  `FQZZFZLJGBZ` text COMMENT '附墙支座防坠落结构备注',
  `FZLZZLMKKJYJG` text COMMENT '防坠落装置灵敏可靠检验结果',
  `FZLZZLMKKJL` text COMMENT '防坠落装置灵敏可靠结论',
  `FZLZZLMKKBZ` text COMMENT '防坠落装置灵敏可靠备注',
  `FZLZZDLGDJYJG` text COMMENT '防坠落装置独立固定检验结果',
  `FZLZZDLGDJL` text COMMENT '防坠落装置独立固定结论',
  `FZLZZDLGDBZ` text COMMENT '防坠落装置独立固定备注',
  `FCFWRJYJG` text COMMENT '防尘防污染检验结果',
  `FCFWRJL` text COMMENT '防尘防污染结论',
  `FCFWRBZ` text COMMENT '防尘防污染备注',
  `GDGSFZLZZJYJG` text COMMENT '钢吊杆式防坠落装置检验结果',
  `GDGSFZLZZJL` text COMMENT '钢吊杆式防坠落装置结论',
  `GDGSFZLZZBZ` text COMMENT '钢吊杆式防坠落装置备注',
  `FQFZZBKDGJYJG` text COMMENT '防倾覆装置包括导轨检验结果',
  `FQFZZBKDGJL` text COMMENT '防倾覆装置包括导轨结论',
  `FQFZZBKDGBZ` text COMMENT '防倾覆装置包括导轨备注',
  `SZFQDGJYJG` text COMMENT '设置防倾导轨检验结果',
  `SZFQDGJL` text COMMENT '设置防倾导轨结论',
  `SZFQDGBZ` text COMMENT '设置防倾导轨备注',
  `FZSXZKJQXJYJG` text COMMENT '防止竖向主框架倾斜检验结果',
  `FZSXZKJQXJL` text COMMENT '防止竖向主框架倾斜结论',
  `FZSXZKJQXBZ` text COMMENT '防止竖向主框架倾斜备注',
  `SJSBMPJYJG` text COMMENT '升降设备铭牌检验结果',
  `SJSBMPJL` text COMMENT '升降设备铭牌结论',
  `SJSBMPBZ` text COMMENT '升降设备铭牌备注',
  `DDHLJJYJG` text COMMENT '电动葫芦机检验结果',
  `DDHLJJL` text COMMENT '电动葫芦机结论',
  `DDHLJBZ` text COMMENT '电动葫芦机备注',
  `LTWHJYJG` text COMMENT '链条完好检验结果',
  `LTWHJL` text COMMENT '链条完好结论',
  `LTWHBZ` text COMMENT '链条完好备注',
  `CQLSZJCDJYJG` text COMMENT '穿墙螺栓直径长度检验结果',
  `CQLSZJCDJL` text COMMENT '穿墙螺栓直径长度结论',
  `CQLSZJCDBZ` text COMMENT '穿墙螺栓直径长度备注',
  `DBCCJYJG` text COMMENT '垫板尺寸检验结果',
  `DBCCJL` text COMMENT '垫板尺寸结论',
  `DBCCBZ` text COMMENT '垫板尺寸备注',
  `XZHZZKXTJYJG` text COMMENT '限制荷载自控系统检验结果',
  `XZHZZKXTJL` text COMMENT '限制荷载自控系统结论',
  `XZHZZKXTBZ` text COMMENT '限制荷载自控系统备注',
  `CZSZBJTJJYJG` text COMMENT '超载失载报警停机检验结果',
  `CZSZBJTJJL` text COMMENT '超载失载报警停机结论',
  `CZSZBJTJBZ` text COMMENT '超载失载报警停机备注',
  `XSJYCCJYJG` text COMMENT '显示记忆储存检验结果',
  `XSJYCCJL` text COMMENT '显示记忆储存结论',
  `XSJYCCBZ` text COMMENT '显示记忆储存备注',
  `MMSAQLWJYJG` text COMMENT '密目式安全立网检验结果',
  `MMSAQLWJL` text COMMENT '密目式安全立网结论',
  `MMSAQLWBZ` text COMMENT '密目式安全立网备注',
  `FHLGGDJYJG` text COMMENT '防护栏杆高度检验结果',
  `FHLGGDJL` text COMMENT '防护栏杆高度结论',
  `FHLGGDBZ` text COMMENT '防护栏杆高度备注',
  `DJBGDJYJG` text COMMENT '挡脚板高度检验结果',
  `DJBGDJL` text COMMENT '挡脚板高度结论',
  `DJBGDBZ` text COMMENT '挡脚板高度备注',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of jsj_keep
-- ----------------------------
INSERT INTO `jsj_keep` VALUES ('260fafa9-7d6a-42b5-a8a3-a1793ad2061b', 'value', '2016-08-14 18:19:11', '1', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');
INSERT INTO `jsj_keep` VALUES ('757962c2-f697-4e85-87a3-22e2dc1efc71', 'value1', '2016-08-14 18:18:53', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');

-- ----------------------------
-- Table structure for news
-- ----------------------------
DROP TABLE IF EXISTS `news`;
CREATE TABLE `news` (
  `newsid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '新闻编号',
  `newstitle` varchar(50) COLLATE utf8_bin NOT NULL COMMENT '新闻标题',
  `newsistj` bit(1) NOT NULL COMMENT '新闻推荐',
  `newsislogo` bit(1) NOT NULL COMMENT '新闻有预览图',
  `newslogo` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '新闻url',
  `newsdate` datetime NOT NULL COMMENT '新闻发布时间',
  `newssummary` varchar(500) COLLATE utf8_bin DEFAULT NULL COMMENT '新闻简介',
  `newscontent` text COLLATE utf8_bin COMMENT '新闻内容',
  `newsclicks` int(11) DEFAULT NULL,
  `newstype` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`newsid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of news
-- ----------------------------
INSERT INTO `news` VALUES ('0a4bd88f-740b-450f-9af6-90d34bc31ca5', '2015全国建筑物资租赁承包行业年会在无锡隆重召开', '', '', '/fileupload/news/Original/f132a3c1491442888defe260fc36c17e.png', '2015-11-11 00:00:00', '2015全国建筑物资租赁承包行业年会在无锡隆重召开', 0x3C70207374796C653D22746578742D616C69676E3A6C6566743B746578742D696E64656E743A33302E3170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E32303135E5B9B43131E69C8839E697A5EFBD9E3130E697A5EFBC8C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4B8ADE59BBDE59FBAE5BBBAE789A9E8B584E7A79FE8B581E689BFE58C85E58D8FE4BC9AE59CA8E697A0E994A1E5B882E59BBDE99985E9A5ADE5BA97E58FACE5BC803C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E32303135E585A8E59BBDE5BBBAE7AD91E789A9E8B584E7A79FE8B581E689BFE58C85E8A18CE4B89AE5B9B4E4BC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE2809DE38082E69DA5E887AAE585A8E59BBDE59084E59CB0E79A84333030E4BD99E5908DE4BC9AE59198E4BBA3E8A1A8E6ACA2E8819AE4B880E5A082EFBC8CE585B1E595863C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE696B0E5B8B8E68081E4B88BE7A79FE8B581E689BFE58C85E8A18CE4B89AE8BDACE59E8BE58D87E7BAA7EFBC8CE585B1E4BF83E8A18CE4B89AE58F91E5B195E5A4A7E8AEA13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E266E6273703B266E6273703B266E6273703B20E9A696E58588EFBC8CE794B1E697A0E994A1E5B882E4BD8FE5BBBAE5B180E4BD95E8B783E5B9B3E589AFE5B180E995BFE59091E4B88EE4BC9AE4BBA3E8A1A8E887B4E6ACA2E8BF8EE8BE9EE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A33302E3170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE784B6E5908EEFBC8CE794B1E4B8ADE5BBBAE7A79FE58D8FE58898E883BDE69687E4BC9AE995BFE5819A32303135E5B9B4E5B7A5E4BD9CE68AA5E5918AE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B666F6E742D7765696768743A626F6C643B223E266E6273703B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E266E6273703B266E6273703B20E5A4A7E4BC9AE8BF98E789B9E588ABE98280E8AFB7E588B0E59BBDE58AA1E999A2E58F91E5B195E7A094E7A9B6E4B8ADE68980E89197E5908DE7BB8FE6B58EE5ADA6E5AEB6E4BBBBE585B4E6B4B2E7A094E7A9B6E59198E5819AE2809CE5BD93E5898DE5AE8FE8A782E7BB8FE6B58EE5BDA2E58ABFE58886E69E90E2809DE79A84E68AA5E5918AE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A33302E3170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE59CA8E5A4A7E4BC9AE4BAA4E6B581E998B6E6AEB5EFBC8CE4BC9AE59198E4BBA3E8A1A8E7BAB7E7BAB7E8B88AE8B783E58F91E8A880EFBC9AE79585E8B088E4BC81E4B89AE58F91E5B195E4B98BE7BB8FE9AA8C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EEFBC9BE5BC803C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE5B195E8A18CE4B89AE68A80E69CAFE5889BE696B0E4BAA4E6B5813C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EEFBC9B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4BB8BE7BB8DE696B0E68A80E69CAFE38081E696B0E4BAA7E59381E38081E696B0E6A087E587863C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EEFBC9B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4BB8BE7BB8DE4BC81E4B89AE4B88AE5B882E38081E8A18CE4B89AE4BAA7E4B89AE59FBAE98791E7AD89E8B584E69CACE8BF90E4BD9CE6A8A1E5BC8F3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EEFBC9BE58886E4BAABE2809CE6A8A1E69DBFE8849AE6898BE69EB6E4B893E4B89AE689BFE58C85E8B584E8B4A8E2809DE794B3E58A9EE7BB8FE9AA8CE4B88EE5BF83E5BE97E4BD93E4BC9AEFBC9B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE68EA2E8AEA83C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4BAA7E4B89AE58F91E5B1953C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE78EB0E78AB6E4B88EE58F91E5B195E8B68BE58ABF3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EEFBC9BE7A094E8AEA8E5BBBAE7AD91E789A9E8B584E7A79FE8B581E689BFE58C85E8A18CE4B89AE5A682E4BD95E5BA94E5AFB9E2809CE890A5E694B9E5A29EE2809DE7AD89E997AEE9A298E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A33302E3170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4BC9AE8AEAE3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE99A86E9878DE68EA8E587BAE585A8E59BBDE6A8A1E69DBFE8849AE6898BE69EB6E7AD89E7BAA7E8AF84E5AE9AE8BEBEE6A087E4BC81E4B89A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE380813C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE58D8FE4BC9AE7A791E68A80E8BF9BE6ADA5E5A596E88EB7E5A596E58D95E4BD8D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B666F6E742D7765696768743A626F6C643B223E266E6273703B266E6273703B266E6273703B203C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4BC9AE8AEAEE8A1A8E5BDB0E4BA86E585A8E59BBDE6A8A1E69DBFE8849AE6898BE69EB6E7A79FE8B581E689BFE58C85E8A18CE4B89AE58D81E5A4A7E9A38EE4BA91E4BABAE789A9E380813330E5BCBAE4BC81E4B89A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE38082E5908AE7AFAEE8A18CE4B89AE9BE99E5A4B4E4BC81E4B89AE794B3E994A1E69CBAE6A2B0E585ACE58FB8E88DA3E88EB7266E6273703BE2809C3330E5BCBAE4BC81E4B89AE2809DE7A7B0E58FB7EFBC8CE590B4E69DB0E680BBE7BB8FE79086E88EB7E5BE97E2809CE4BC98E7A780E99D92E5B9B4E4BC81E4B89AE5AEB63C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE2809DE58589E88DA3E7A7B0E58FB73C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B666F6E742D7765696768743A626F6C643B223E266E6273703B266E6273703B266E6273703B203C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE58D8FE4BC9AE7BB8FE8BF87E4B8A5E6A0BCE79A84E4B893E5AEB6E8AF84E5AEA1EFBC8CE586B3E5AE9AE68E88E4BA88E697A0E994A1E5B882E2809CE5908AE7AFAEE4B98BE4B9A1E2809DE58589E88DA3E7A7B0E58FB7E38082E4B8ADE5BBBAE7A79FE58D8FE58898E69687E883BDE4BC9AE995BFE59091E6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE590B4E4BB81E5B1B1E4BC9AE995BFE68E88E4BA88E2809CE5908AE7AFAEE4B98BE4B9A1E2809DE9939CE7898CE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B666F6E742D7765696768743A626F6C643B223E266E6273703B266E6273703B266E6273703B203C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE58D8FE4BC9AE5A29EE8A1A5E4BA86E4B893E5AEB6E5A794E59198E4BC9AE5A794E59198E38082E6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE7A798E4B9A6E995BFE38081E9AB98E7A9BAE69CBAE6A2B0E5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E999A2E596BBE683A0E4B89AE999A2E995BFE68EA5E58F97E2809CE4B893E5AEB6E5A794E59198E4BC9AE5A794E59198E88198E4B9A6E2809DE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223E203C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B666F6E742D7765696768743A626F6C643B223E266E6273703B266E6273703B266E6273703B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE585A8E4BD93E4B88EE4BC9AE4BBA3E8A1A8E8BF98E585B4E887B4E58B83E58B83E59CB0E58F82E8A782E88083E5AF9FE4BA86E8A18CE4B89AE9BE99E5A4B4E4BC81E4B89AE697A0E994A1E9809FE5BBBAE8849AE6898BE69EB6E5B7A5E7A88BE69C89E99990E585ACE58FB8E38081E794B3E994A1E69CBAE6A2B0E69C89E99990E585ACE58FB8E5928CE9AB98E7A9BAE69CBAE6A2B0E5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E999A2E380823C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B666F6E742D7765696768743A626F6C643B223E266E6273703B266E6273703B266E6273703B266E6273703B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313570743B223EE4BC9AE5908EEFBC8CE6B19FE88B8FE79C81E5928CE697A0E994A1E5B882E79A84E59084E8B7AFE5AA92E4BD93E5AFB9E697A0E994A1E5B882E88EB7E5BE97E2809CE5908AE7AFAEE4B98BE4B9A1E2809DE7A7B0E58FB7E79A84E696B0E997BBE7ACACE4B880E697B6E997B4E8BF9BE8A18CE68AA5E5AFBCE380823131E69C883130E697A5E3808AE58D97E4BAACE699A8E68AA5E3808BE78E87E58588E58F91E8A1A8E4BA86E3808AE6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE8A2ABE68E88E4BA88E2809CE5908AE7AFAEE4B98BE4B9A1E2809DE7A7B0E58FB7E3808BE79A84E69687E7ABA0EFBC9BE3808AE697A0E994A1E59586E68AA5E3808BE4BBA5E3808AE5B882E59CBAE58DA0E69C89E78E87E9AB98266E6273703BE697A0E994A1E88EB7E79B8AE2809CE5908AE7AFAEE4B98BE4B9A1E2809DE3808BE4B8BAE9A298E8BF9BE8A18CE68AA5E5AFBCE380823C2F7370616E3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '257', '00001');
INSERT INTO `news` VALUES ('2acb9b88-8eb4-41dc-a738-fbd8a186cdc1', '建设局：省建筑安全标准化考核研讨会、附着式升降脚手架和高处作业吊篮监管问题座谈会在常召开', '', '\0', null, '2015-08-26 00:00:00', '围绕省厅起草的《关于进一步加强附着式升降脚手架和高处作业吊篮监督管理的通知》展开座谈', 0x3C70207374796C653D22746578742D616C69676E3A63656E7465723B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A417269616C3B6261636B67726F756E643A236666666666663B636F6C6F723A233361366662303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE69DA5E6BA903C7370616E3E3A3C2F7370616E3E3C7370616E3EE5B882E59F8EE4B9A1E5BBBAE8AEBEE5B1803C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A43616C696272693B666F6E742D73697A653A31302E3570743B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E38E69C883231E697A5E4B88AE58D88EFBC8CE6B19FE88B8FE79C81E5BBBAE7AD91E5AE89E585A8E6A087E58786E58C96E88083E6A0B8E7A094E8AEA8E4BC9AE38081E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE79B91E7AEA1E997AEE9A298E5BAA7E8B088E4BC9AE59CA8E68891E5B882E58FACE5BC80E38082E79C81E4BD8FE5BBBAE58E85E8B4A8E5AE89E5A484E589AFE5A484E995BFE69D8EE788B1E59BBDE38081E590B4E5B09AE69DBEE38081E79C81E4BD8FE5BBBAE58E85E5BBBAE7AEA1E680BBE7AB99E680BBE5B7A5E7A88BE5B888E78E8BE7BEA4E4BE9DE38081E79C81E5AE89E79B91E680BBE7AB99E589AFE7AB99E995BFE69BB9E698A5E58589E38081E79C81E5BBBAE7AD91E5AE89E585A8E4B88EE8AEBEE5A487E7AEA1E79086E58D8FE4BC9AE4BBA3E8A1A8E38081E5B882E59F8EE4B9A1E5BBBAE8AEBEE5B180E589AFE5B180E995BFE8B4A1E6B5A9E5B9B3EFBC8CE4BBA5E58F8AE69DA5E887AAE58D97E4BAACE38081E5BE90E5B79EEFBC8CE697A0E994A1E38081E58D97E9809AE38081E6B3B0E5B79EE5AE89E79B91E7AB99E38081E983A8E58886E4BC81E4B89AE4BBA3E8A1A83330E4BD99E4BABAE58886E588ABE58F82E58AA0E4BA86E7A094E8AEA8E5928CE5BAA7E8B088E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE59CA8E5BBBAE7AD91E5AE89E585A8E6A087E58786E58C96E88083E6A0B8E7A094E8AEA8E4BC9AE4B88AEFBC8CE4B88EE4BC9AE4BABAE59198E59BB4E7BB95E8B5B7E88D89E79A84E3808AE6B19FE88B8FE79C81E5BBBAE7AD91E696BDE5B7A5E78EB0E59CBAE5AE89E585A8E7949FE4BAA7E6A087E58786E58C96E6A380E69FA5E6A087E58786E3808BEFBC8CE9878DE782B9E8AEA8E8AEBAE2809CE5AE89E585A8E7949FE4BAA7E7AEA1E79086E588B6E5BAA6E5BBBAE8AEBEE2809DE38081E2809CE58DB1E999A9E680A7E8BE83E5A4A7E58886E983A8E58886E9A1B9E5B7A5E7A88BE4B893E9A1B9E696B9E6A188E58F8AE79B91E68EA7E2809DE38081E2809CE5AE89E585A8E7949FE4BAA7E6A087E58786E58C96E7AD96E58892E4B88EE5AE9EE696BDE2809DE4B889E4B8AAE983A8E58886E79A84E88083E6A0B8E6A087E58786EFBC9BE7BB93E59088E79C81E7BAA7E6A087E58786E58C96E5AE89E585A8E69687E6988EE5B7A5E59CB0E6A380E69FA5E8AF84E58886E8A1A8E79A84E88BA5E5B9B2E9A1B9E69DA1E6ACBEEFBC8CE58C85E68BACE5B882E694BFE5B7A5E7A88BE696BDE5B7A5E78EB0E59CBAE5AE89E585A8E7949FE4BAA7E6A087E58786E58C96E6A380E69FA5E9A1B9E79BAEE5928CE88083E6A0B8E6A087E58786E8BF9BE8A18CE58585E58886E6B29FE9809AE4BAA4E6B581E38082E5A4A7E5AEB6E4B880E887B4E8AEA4E4B8BAEFBC9AE59CA8E4B8A5E6A0BCE981B5E5AE88E4BD8FE5BBBAE983A8E3808AE5BBBAE7AD91E696BDE5B7A5E5AE89E585A8E7949FE4BAA7E6A087E58786E58C96E88083E8AF84E69A82E8A18CE58A9EE6B395E3808BEFBC88E5BBBAE8B4A8E3809432303134E38095313131E58FB7EFBC89E69C89E585B3E88083E8AF84E7AEA1E79086E58A9EE6B395E79A84E59FBAE7A180E4B88AEFBC8CE8A681E8BF9BE4B880E6ADA5E5BC80E68B93E6809DE8B7AFEFBC8CE5889BE696B0E696B9E6B395EFBC8CE69C89E69588E8A7A3E586B3E79BAEE5898DE5AD98E59CA8E79A84E4BC81E4B89AE5AE89E585A8E7AEA1E79086E4B88EE9A1B9E79BAEE5AE89E585A8E7AEA1E79086E884B1E88A82E4B8A5E9878DE79A84E997AEE9A298EFBC8CE4B88DE696ADE68F90E9AB98E4BC81E4B89AE5AE89E585A8E7949FE4BAA7E7AEA1E79086E6B0B4E5B9B3EFBC8CE58887E5AE9EE694B9E59684E9A1B9E79BAEE5AE89E585A8E7949FE4BAA7E69DA1E4BBB6EFBC8CE69C89E69588E68F90E9AB98E4BA8BE69585E9A284E998B2E883BDE58A9BE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE59CA8E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE79B91E7AEA1E997AEE9A298E5BAA7E8B088E4BC9AE4B88AEFBC8CE4B88EE4BC9AE4BABAE59198E59BB4E7BB95E79C81E58E85E8B5B7E88D89E79A84E3808AE585B3E4BA8EE8BF9BE4B880E6ADA5E58AA0E5BCBAE99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE79B91E79DA3E7AEA1E79086E79A84E9809AE79FA5E3808BE5B195E5BC80E5BAA7E8B088E38082E59CA8E5BAA7E8B088E4B8ADEFBC8CE5A4A7E5AEB6E8AEA4E4B8BAEFBC8CE99A8FE79D80E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE8BF90E794A8E8A784E6A8A1E8B68AE69DA5E8B68AE5A4A7EFBC8CE5BBBAE7AD91E68A80E69CAFE79A84E8BF90E794A8E5928CE5BBBAE7AD91E5AE89E585A8E79A84E79F9BE79BBEE4B99FE99A8FE4B98BE587B8E78EB0E38082E99C80E8BF9BE4B880E6ADA5E58AA0E5BCBAE99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE79B91E79DA3E7AEA1E79086EFBC8CE4B8A5E6A0BCE890BDE5AE9EE4BC81E4B89AE4B8BBE4BD93E8B4A3E4BBBBEFBC8CE68F90E9AB98E4BC81E4B89AE7AEA1E79086E6B0B4E5B9B3EFBC8CE8A784E88C83E5928CE7BB9FE4B880E585A8E79C81E5AE89E585A8E79B91E79DA3E7AEA1E79086E588B6E5BAA6E38082E4B88EE4BC9AE4BABAE59198E5AFB9E4B88BE4B880E6ADA5E5A682E4BD95E58AA0E5BCBAE5928CE5AE8CE59684E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE7AEA1E79086E68EAAE696BDE59084E68A92E5B7B1E8A781EFBC8CE4B8BAE79C81E58E85E5B0BDE5BFABE588B6E5AE9AE38081E5AE8CE59684E7BB9FE4B880E79A84E8A784E7ABA0E5928CE58A9EE6B395EFBC8CE68EA8E58AA8E585A8E79C81E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E5928CE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE79A84E5AE89E585A8E79B91E7AEA1E5B7A5E4BD9CE8B5B0E59091E8A784E88C83E58C96E38081E6B395E588B6E58C96E79A84E8BDA8E98193EFBC8CE68F90E4BE9BE8A18CE4B98BE69C89E69588E79A84E889AFE7AD96E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E, '61', '00001');
INSERT INTO `news` VALUES ('3f1e849a-eb0e-4e07-a523-d135f0faa430', '高空作业升降机械未来走向及发展现状', '', '\0', null, '2016-01-06 00:00:00', '', 0x3C70207374796C653D22746578742D616C69676E3A63656E7465723B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A31302E3570743B223EE69DA5E6BA90EFBC9A3C2F7370616E3E3C7370616E3E3C6120687265663D22687474703A2F2F7777772E6365686F6D652E636F6D2F223E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030363539383B666F6E742D73697A653A3970743B666F6E742D7765696768743A6E6F726D616C3B2220636C6173733D223136223EE99381E794B2E5B7A5E7A88BE69CBAE6A2B0E7BD913C2F7370616E3E3C2F613E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030363539383B666F6E742D73697A653A3970743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE79BAEE5898DEFBC8CE59BBDE58685E79A84E9AB98E7A9BAE4BD9CE4B89AE58D87E9998DE8AEBEE5A487E5B882E59CBAE9B1BCE9BE99E6B7B7E69D82EFBC8CE69C89E5A4A7E59E8BE79A84E59BBDE58685E79FA5E5908DE59381E7898CE4BC81E4B89AE38081E69C89E4B8ADE5A496E59088E8B584E38081E5B08FE4BC81E4B89AE5A682E99BA8E5908EE698A5E7AC8BE888ACE587BAE78EB0E38082E5908CE697B6EFBC8CE59BBDE58685E79A84E9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E59381E7A78DE695B0E9878FE4B88DE696ADE5A29EE58AA0EFBC8CE59084E5BC8FE59084E6A0B7E79A84E9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E983BDE69C89EFBC81E680A7E883BDE38081E4BBB7E6A0BCE38081E5B882E59CBAE68385E586B5E8BF99E4BA9BEFBC8CE4B88DE4BB85E4BB85E8AEA9E5AEA2E688B7E691B8E4B88DE6B885E997A8E8B7AFEFBC8CE5BE88E5A49AE4BC81E4B89AE38081E7A79FE8B581E59586E4B99FE4BF9DE68C81E79D80E8A782E69C9BE79A84E68081E5BAA6E38082E5BD93E4BB8AE79A84E9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E8A18CE4B89AE6808EE4B988E6A0B7EFBC9FE69CAAE69DA5E9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E79A84E58F91E5B195E696B9E59091E59CA8E593AAE9878CEFBC9F3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A313270743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE8BF91E587A0E5B9B4E68891E59BBDE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E79A84E58F91E5B195E4B8BBE8A681E8A1A8E78EB0E59CA8E4BBA5E4B88BE587A0E4B8AAE696B9E99DA2EFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE59381E7A78DE695B0E9878FE4B88DE696ADE5A29EE58AA03C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE68891E59BBDE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E4BAA7E59381E99A8FE79D80E59BBDE6B091E7BB8FE6B58EE5928CE59F8EE5B882E5BBBAE8AEBEE79A84E58F91E5B195E99C80E6B182E9878FE98090E5B9B4E5A29EE58AA02CE59084E7A78DE8A784E6A8A1E79A84E696B0E4BAA7E59381E5928CE59381E7A78DE8BF91E587A0E5B9B4E5A29EE58AA0E8BE83E5BFABE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE4BAA7E59381E680A7E883BDE69C89E8BE83E5A4A7E68F90E9AB983C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE68891E59BBDE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E4BAA7E59381E9809AE8BF87E5ADA6E4B9A0E38081E5BC95E8BF9BE5928CE6B688E58C96E59BBDE5A496E58588E8BF9BE68A80E69CAFE5BC80E58F91E4BA86E8AEB8E5A49AE696B0E4BAA7E593812CE585B6E4BAA7E59381E79A84E68A80E69CAFE6B0B4E5B9B3E5928CE4BAA7E59381E8B4A8E9878FE983BDE4B88DE696ADE68F90E9AB982CE8BEBEE588B0E5928CE68EA5E8BF91E4BA86E59BBDE99985E5908CE7B1BBE4BAA7E59381E79A84E6B0B4E5B9B32CE59CA8E59BBDE58685E5B882E59CBAE4B8ADE7AB9EE4BA89E58A9BE5BCBA2CE5B882E59CBAE99480E8B7AFE5A5BD2CE4BAA7E9878FE4B99FE5A29EE58AA0E8BE83E5BFABE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE5B882E59CBAE4BBBDE9A29DE8BF9BE4B880E6ADA5E689A9E5A4A73C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4B880E4BA9BE4BC81E4B89AE588A9E794A8E887AAE8BAABE79A84E4BC98E58ABF2CE59CA8E58E9FE69C89E4BAA7E59381E79A84E59FBAE7A180E4B88AE6A0B9E68DAEE59BBDE58685E5BA95E79B98E59381E7A78DE79A84E5A29EE58AA0E5928CE4B880E4BA9BE59FBAE7A180E99BB6E983A8E4BBB6E79A84E69BB4E696B02CE4B88DE696ADE58AA0E5A4A7E696B0E4BAA7E59381E79A84E5BC80E58F91E58A9BE5BAA62CE8B5B0E4BC81E4B89AE6A8AAE59091E88194E59088E5A49AE7A78DE7BB8FE890A5E79A84E7BBBCE59088E5BC80E58F91E8B7AFE5AD902CE4B88DE4BD86E4BDBFE4BC81E4B89AE887AAE8BAABE79A84E7949FE4BAA7E5928CE99480E594AEE6ADA5E585A5E4BA86E889AFE680A7E5BEAAE78EAFE8BDA8E981932CE8BF98E5B8A6E58AA8E4BA86E99984E5B19EE4BC81E4B89AE5928CE59BBDE58685E79BB8E585B3E4BC81E4B89AE4BAA7E59381E79A84E99480E594AEE58F91E5B195E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4BC98E58ABFE4BA92E8A1A52CE68EA8E58AA8E8A18CE4B89AE68A80E69CAFE8BF9BE6ADA5E59BBDE58685E6B1BDE8BDA6E8B5B7E9878DE69CBAE8A18CE4B89AE79A84E4B880E4BA9BE5A4A7E4B8ADE59E8BE4BC81E4B89A2CE588A9E794A8E887AAE5B7B1E79A84E68A80E69CAFE4BC98E58ABFE5928CE8AEBEE5A487E4BC98E58ABFE8BF91E5B9B4E69DA5E7BAB7E7BAB7E5BC80E58F91E4BA86E8AEB8E5A49AE69CACE8A18CE4B89AE4BAA7E59381E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A313270743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE8A18CE4B89AE8BF91E5B9B4E69DA5E5AD98E59CA8E79A84E4B8BBE8A681E997AEE9A298EFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE983A8E58886E5B08FE4BC81E4B89AE68A80E69CAFE5889BE696B0E883BDE58A9BE8BE83E5B7AE3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE983A8E58886E5B08FE4BC81E4B89AE4B88DE9878DE8A786E4BAA7E59381E69BB4E696B0E5928CE696B0E4BAA7E59381E79A84E5BC80E58F912CE4BAA7E59381E587A0E58D81E5B9B4E4B880E8B4AFE588B62CE59381E7A78DE8A784E6A0BCE58D95E4B880E38081E5B882E59CBAE7BB8FE890A5E88C83E59BB4E7AA842CE4BDBFE4BC81E4B89AE4BAA7E59381E4BAA7E9878FE98090E5B9B4E4B88BE9998D2CE4BC81E4B89AE69588E79B8AE5B7AEE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE59FBAE7A180E99BB6E983A8E4BBB6E9858DE5A597E6B0B4E5B9B3E69CAAE8B79FE4B88A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE59BBDE58685E4B880E4BA9BE4BAA7E59381E79A84E59FBAE7A180E99BB6E983A8E4BBB6E9858DE5A597E7949FE4BAA7E58E82E5AEB6E5B0912CE8A784E6A0BCE59381E7A78DE5B0912CE9858DE5A597E6B0B4E5B9B3E8BF98E8BE83E5B7AE2CE794B5E6B094E58583E4BBB6E38081E6B6B2E58E8BE58583E4BBB6E38081E58AA8E58A9BE983A8E4BBB6E79A84E680A7E883BDE5928CE4BDBFE794A8E58FAFE99DA0E680A7E8BF98E4B88DE9AB982CE8BF99E4B99FE5BDB1E5938DE4BA86E59BBDE58685E4BAA7E59381E79A84E5BC80E58F91E38082E5A4A7E5A49AE59BBDE58685E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E7949FE4BAA7E4BC81E4B89AE59CA8E8BF99E7B1BBE99BB6E983A8E4BBB6E79A84E98089E9858DE696B9E99DA2EFBC8CE983BDE698AFE98787E794A8E9AB98E4BBB7E8BF9BE58FA3E59BBDE5A496E99BB6E983A8E4BBB6E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE4B893E4B89AE7A094E58F91E7949FE4BAA7E6B0B4E5B9B3E4BD8E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE59BBDE58685E5A4A7E983A8E58886E4BC81E4B89AE4BBA5E6A8A1E4BBBFE8BF9BE58FA3E8BDA6E59E8BE7949FE4BAA7E4B8BAE4B8BB2CE4B893E4B89AE58C96E7949FE4BAA7E6B0B4E5B9B3E5BE88E4BD8E2CE5B7A5E889BAE890BDE5908E2CE58AB3E58AA8E7949FE4BAA7E78E87E4BD8EE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE5B08FE4BD9CE59D8AE5BC8FE4BC81E4B89AE8BE83E5A49A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4B880E4BA9BE5B08FE585ACE58FB8E38081E5B08FE4BD9CE59D8AE5BC8FE4BC81E4B89AE7BAB7E7BAB7E8B5B7E69DA52CE5A682E59CA8E6B19FE88B8FE7AD89E59CB0E4B880E4B8AAE59CB0E58CBAE5B0B1E69C89E695B0E58D81E5AEB6E4BC81E4B89A2CE8BF99E4BA9BE5B08FE4BC81E4B89AE4BAA7E9878FE4BD8EE38081E8B4A8E9878FE5B7AEE38081E4BBB7E6A0BCE4BD8E2CE4B8A5E9878DE586B2E587BBE5928CE5BDB1E5938DE79D80E6ADA3E5B8B8E79A84E5B882E59CBAE99480E594AEE38082E69CAAE69DA535E5B9B4E698AFE5AE9EE78EB0E69CBAE6A2B0E38081E5BBBAE7AD91E4B89AE68CAFE585B4E79BAEE6A087E79A84E585B3E994AE35E5B9B4E38082E6A0B9E68DAEE585A8E59BBDE5B7A5E7A88BE69CBAE6A2B0E8A18CE4B89AE69CAAE69DA535E5B9B4E58F91E5B195E8A784E58892E58F8AE59BADE69E97E4B88EE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E8A18CE4B89A2CE9AB98E7A9BAE4BD9CE4B89AE8A18CE4B89AE4BD9CE4B8BAE59F8EE5B882E5BBBAE8AEBEE79A84E696B0E59E8BE4BAA7E4B89A2CE9A696E58588E5BF85E9A1BBE8B083E695B4E4BAA7E59381E7BB93E69E842CE4BB8EE696BDE5B7A5E4BD9CE4B89AE4B8ADE69C80E4B8BAE7B981E9878DE79A84E58AB3E58AA8E4B8ADE8A7A3E884B1E587BAE69DA52CE4BBA5E5AE9EE78EB0E69CBAE6A2B0E58C96E38082E8A681E68A93E5A5BDE59F8EE5B882E585ACE794A8E5BBBAE7AD91E38081E4BE9BE794B5E794A8E9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E4BAA7E593812CE5BBBAE7AD91E794A8E887AAE8A18CE5BC8FE799BBE9AB98E4BD9CE4B89AE69CBAE6A2B0E58F8AE5B8A6E794B5E7BB9DE7BC98E9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E4BAA7E59381E79A84E5BC80E58F912CE5AEA4E58685E5A496E8BDBBE59E8BE4BD9CE4B89AE5B9B3E58FB0E5928C3435E7B1B3E4BBA5E4B88AE6B688E998B2E69591E68FB4E9AB98E7A9BAE4BD9CE4B89AE8BDA6E79A84E5BC80E58F91E5928CE5BA94E794A8E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE79BAEE5898D2CE59BBDE5A496E9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E59381E7A78DE8A784E6A0BCE7B981E5A49A2CE5B7B2E5BDA2E68890E4B880E4B8AAE99D9EE5B8B8E5A4A7E79A84E8A18CE4B89A2CE5B9B6E4B894E68890E7AB8BE4BA86E59BBDE99985E6A087E58786E58C96E7BB84E7BB87E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A313270743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE6A0B9E68DAEE79BAEE5898DE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E79A84E58F91E5B195E68385E586B52CE68891E59BBDE8AFA5E4BAA7E59381E5BA94E9878DE782B9E8A7A3E586B3E4BBA5E4B88BE587A0E4B8AAE997AEE9A298EFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4BAA7E59381E59CA8E6938DE4BD9CE4BDBFE794A8E696B9E99DA2E79A84E69BB4E696B0E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E4BAA7E59381E4BBA5E5BE80E59BBDE58685E5A4A7E5A49AE4BBA5E6898BE68EA8E5BC8FE4B8BAE4B8BB2CE4BD93E7A7AFE5A4A7E38081E9878DE9878FE9878D2CE69BB4E68DA2E5B7A5E4BD9CE59CBAE59CB0E99D9EE5B8B8E59BB0E99ABE2CE7BB99E794A8E688B7E4BDBFE794A8E5B8A6E69DA5E4B88DE4BEBF2CE8BF99E4B880E782B9E59BBDE5A496E58588E8BF9BE59BBDE5AEB6E59CA8E4BAA7E59381E4B88AE697A9E5B7B2E69BB4E696B0E38082E59BA0E6ADA42CE5BC80E58F91E8BDBBE4BEBFE79A84E9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E7949FE4BAA7E4BC81E4B89AE4BB8E3730E5B9B4E4BBA3E8B5B7E6ADA52CE887B3E4BB8AE5B7B2E69C89E8BF913330E5B9B4E79A84E58E86E58FB2E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E59BBDE58685E5A4A7E5A49AE695B0E58E82E5AEB6E68A8AE794A8E688B7E99B86E4B8ADE59CA8E8BDA6E7AB99E38081E59CB0E99381E38081E59586E5BA97E38081E5B7A5E58E82E38081E4BE9BE794B5E38081E8B7AFE781AFE7AD89E983A8E997A82CE4BD86E585B6E5B882E59CBAE8BF9CE8BF9CE6B2A1E69C89E68C96E68E98E5928CE59FB9E882B2E587BAE69DA5E38082E7A9B6E585B6E58E9FE59BA0E698AFE59BBDE58685E8AFA5E4BAA7E59381E59381E7A78DE58D95E4B8802CE4BAA7E59381E59CA8E794A8E98094E5928CE58A9FE883BDE4B88AE8BF98E99C80E69BB4E696B0E38082E6AF94E5A6822CE5B086E9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E794A8E59CA8E5BBBAE7AD91E696BDE5B7A5E4B8ADE4BBA5E69BBFE4BBA3E69F90E4BA9BE8849AE6898BE69EB6E696BDE5B7A5E38081E5BBBAE7AD91E789A9E5A496E5A299E8A1A8E99DA2E79A84E8A385E9A5B0E38081E6B885E6B497E5928CE7BBB4E68AA4E7AD893BE7BB9DE7BC98E69EB6E7BABFE5928CE7BBB4E4BFAE3BE6B688E998B2E69591E68FB4E58F8AE5A4A7E59E8BE789A9E4BD9328E888B9E888B6E38081E9A39EE69CBA29E7BBB4E68AA4E6A380E69FA5E7AD89E38082E4BD86E5BC80E58F91E4BBA5E4B88AE8BF99E4BA9BE4BAA7E59381E99C80E8A681E4BB8EE4BAA7E59381E79A84E98082E5BA94E680A7E4B88AE38081E4BAA7E59381E79A84E68A80E69CAFE4B88AE69C89E5BE88E5A4A7E79A84E7AA81E7A0B4E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE59BB4E7BB95E4BBA5E4B88AE997AEE9A298E6A0B9E68DAEE59BBDE58685E5A496E5B882E59CBAE58F91E5B195E99C80E8A681E5928CE69CACE8A18CE4B89AE69CAAE69DA535E5B9B4E58F91E5B195E6809DE8B7AF2CE5BBBAE8AEAEE4BC98E58588E58F91E5B195E79A84E4BAA7E59381E5A682E4B88BEFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E612EE5AEA4E58685E5A496E8BDBBE59E8BE4BD9CE4B89AE5B9B3E58FB03B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E622EE5BBBAE7AD91E794A8E887AAE8A18CE5BC8FE4BD9CE4B89AE5B9B3E58FB03B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E632EE5B8A6E794B5E4BD9CE4B89AE794A831306B56E4BBA5E4B88AE79A84E7BB9DE7BC98E9AB98E7A9BAE4BD9CE4B89AE78E873B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E642E32352D3530E7B1B3E5A49AE58A9FE883BDE6B688E998B2E69591E68FB4E4BD9CE4B89AE8BDA6E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE99288E5AFB9E4BBA5E4B88AE4BAA7E59381E5BC80E58F912CE8A18CE4B89AE5928CE4BC81E4B89AE99C80E8A681E59CA8E69CAAE69DA535E5B9B4E69C9FE997B4E58F91E5B195E5928CE7A094E7A9B6E79A84E585B3E994AEE68A80E69CAFE5A682E4B88BEFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E612EE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E79A84E887AAE58AA8E68EA7E588B6E5928CE5AE89E585A8E4BF9DE68AA4E68A80E69CAFE79A84E7A094E7A9B63B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E622EE5AEA4E58685E5A496E8BDBBE59E8BE4BD9CE4B89AE5B9B3E58FB0E58F8AE887AAE8A18CE5BC8FE4BD9CE4B89AE5B9B3E58FB0E79A84E5BC80E58F91E7A094E7A9B63B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E632EE5A4A7E4BD9CE4B89AE5B985E5BAA6E5B9B3E58FB0E58F8AE696B0E59E8BE5A49AE58A9FE883BDE9AB98E7A9BAE4BD9CE4B89AE8BDA6E79A84E5BC80E58F91E7A094E7A9B63B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E642EE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0E7BB9DE7BC98E680A7E883BDE58F8AE9AB98E7A9BAE7BB9DE7BC98E4BD9CE4B89AE69CBAE6A2B0E79A84E5BC80E58F91E7A094E7A9B6E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE680BBE4B98B2CE99A8FE79D80E59F8EE5B882E5BBBAE8AEBEE58F91E5B195E79A84E99C80E8A6812CE58AA0E5A4A7E69CACE8A18CE4B89AE68A80E69CAFE5889BE696B0E58A9BE5BAA62C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE5BC80E58F91E58588E8BF9BE79A84E9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B02CE68F90E9AB98E68891E59BBDE4BAA7E59381E79A84E5B882E59CBAE7AB9EE4BA89E883BDE58A9BE698AFE5BD93E58AA1E4B98BE680A52CE58FAAE69C89E69CACE8A18CE4B89AE5908CE4BB81E79A84E585B1E5908CE58AAAE58A9B2CE68891E4BBACE79A84E4BC81E4B89AE6898DE883BDE8B5A2E5BE97E5B882E59CBA2CE68891E4BBACE79A84E8A18CE4B89AE6898DE883BDE69BB4E5A5BDE59CB0E58F91E5B195E5928CE5A3AEE5A4A7E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E, '152', '00001');
INSERT INTO `news` VALUES ('5836decc-6da2-44dd-b72d-444ef8d9846e', '申锡吊篮助力中国速度--19天57层 长沙“小天城”！', '', '\0', '/fileupload/news/Original/68561dfd17584ea789b65d131c118882.png', '2015-06-16 00:00:00', '长沙小天城，“19天57层”', 0x3C70207374796C653D226261636B67726F756E642D636F6C6F723A236666666666663B746578742D696E64656E743A3070783B636F6C6F723A233365336533653B223E0D0A09266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B20E8BF91E697A5EFBC8CE8BF9CE5A4A7E99B86E59BA2E59CA8E995BFE6B299E58EBFE5BBBAE79A84E2809CE5B08FE5A4A9E59F8EE2809DE68890E4B8BAE783ADE697A5E8AF9DE9A298EFBC8CE2809C3139E5A4A93537E5B182E2809DEFBC8CE2809CE4B880E5A4A9E4B889E5B182E4B8ADE59BBDE696B0E5B8B8E68081E2809C20E79EACE997B4E8B5B0E7BAA2E380820D0A3C2F703E0D0A3C70207374796C653D226261636B67726F756E642D636F6C6F723A236666666666663B746578742D696E64656E743A3070783B636F6C6F723A233365336533653B223E0D0A09266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B20E698A8E697A5E794B3E994A1E69CBAE6A2B0E694B6E588B0E8BF9CE5A4A7E99B86E59BA2E8B49FE8B4A3E4BABAE79A84E6B688E681AFEFBC8CE8AF81E5AE9EE2809DE5B08FE5A4A9E59F8EE2809CE696BDE5B7A5E4BD9CE794A8E5908AE7AFAEE6ADA3E698AFE4BB8EE794B3E994A1E68980E8B4ADEFBC81E7BBA7E8BFAAE68B9CE5A194EFBC8CE58D97E7BE8EE7ACACE4B880E9AB98E6A5BCEFBC8CE5B9BFE5B79EE794B5E8A786E5A194E58F8AE5A4AEE8A786E5A4A7E6A5BCE7AD89E7AD89E997BBE5908DE4B896E7958CE79A84E5BBBAE7AD91E789A9E4B98BE5908EEFBC8CE794B3E994A1E5908AE7AFAEE5868DE6ACA1E8A781E8AF81E4BA86E4B8ADE59BBDE5BBBAE7AD91E79A84E9AB98E5BAA6E5928CE9809FE5BAA6EFBC810D0A3C2F703E0D0A3C7370616E207374796C653D226261636B67726F756E642D636F6C6F723A236666666666663B636F6C6F723A233365336533653B223E266E6273703B266E6273703B266E6273703B266E6273703B266E6273703B20E8BF99E5BAA73537E5B182E79A84E5BBBAE7AD91EFBC8CE9AB98E8BEBE323030E5A49AE7B1B3E38082E8BF9CE5A4A7E58FAFE59CA83139E5A4A9E58685E5AE8CE68890E38082E8BF9CE5A4A7E99B86E59BA2E59CA8596F7554756265E4B88AE58F91E5B883E4BA86E4B880E6AEB5E5BBB6E697B6E69184E5BDB1E5BD95E5838FEFBC8CE8AEB2E695B4E4B8AAE5BBBAE7AD91E789A9E6B593E7BCA9E59CA834E58886E9929FE58685EFBC8CE59BBDE5A496E7BD91E58F8BE6838AE591BCE2809CE58FAAE69C89E4B8ADE59BBDE4BABAE883BDE58A9EE588B0EFBC81E2809D3C2F7370616E3E200D0A3C703E0D0A093C7370616E3E3C2F7370616E3E266E6273703B0D0A3C2F703E, '184', '00001');
INSERT INTO `news` VALUES ('64f1463c-49e8-434f-9ee0-3c7a305bd7b0', '中建租协科技进步奖、“吊篮之乡”专家评审会在京召开', '', '\0', '/fileupload/news/Original/1d00510894f64c339e440b41364aedce.png', '2015-10-11 00:00:00', '中建租协科技进步奖、“吊篮之乡”专家评审会在京召开', 0x3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B666F6E742D7765696768743A626F6C643B223E266E6273703B266E6273703B266E6273703B20E7BC96E88085E6B3A8EFBC9A266E6273703B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223E323C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223E3031353C7370616E3EE5B9B43C2F7370616E3E3C7370616E3E31303C2F7370616E3E3C7370616E3EE69C883C2F7370616E3E3C7370616E3E393C2F7370616E3E3C7370616E3EE697A5EFBC8CE4B8ADE59BBDE59FBAE5BBBAE789A9E8B584E7A79FE8B581E689BFE58C85E58D8FE4BC9AE59CA8E4BAACE58FACE5BC80E4B893E5AEB6E8AF84E5AEA1E4BC9AEFBC8CE5AFB9E6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE794B3E68AA5E79A843C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313470743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313470743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223EE7A7B0E58FB7E8BF9BE8A18CE4B893E5AEB6E8B4A8E8AFA2E4B88EE5AEA1E5AE9AE38082E68C89E785A7E4B8A5E6A0BCE79A84E8AF84E5AEA1E7A88BE5BA8FEFBC8CE7BB8FE8BF87E8B584E69699E8AF84E5AEA1E38081E4B893E5AEB6E8B4A8E8AFA2E38081E7A094E7A9B6E8AEA8E8AEBAE38081E69C80E7BB88E8A1A8E586B3EFBC8CE8AF84E5AEA1E4B893E5AEB6E4B880E887B4E5908CE6848FE68E88E4BA88E697A0E994A1E5B8823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313470743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313470743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223EE7A7B0E58FB7E38082E4B8ADE59BBDE59FBAE5BBBAE789A9E8B584E7A79FE8B581E689BFE58C85E58D8FE4BC9AE5B086E59CA8E4B88BE69C88E58FACE5BC80E79A84E585A8E59BBDE680A7E5B9B4E4BC9AE4B88AE6ADA3E5BC8FE68E88E4BA88E697A0E994A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313470743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313470743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313470743B223EE7A7B0E58FB7EFBC8CE5B9B6E99A86E9878DE4B8BEE8A18CE68E88E7898CE4BBAAE5BC8FE38082E69CACE7BD91E7AB99E585A8E69687E8BDACE8BDBDE4B8ADE5BBBAE7A79FE58D8FE58F91E5B883E79A84E4B893E9A298E68AA5E5AFBCE380823C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E323031353C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5B9B43C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E31303C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE69C883C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E393C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE697A5EFBC8CE4B8ADE59BBDE59FBAE5BBBAE789A9E8B584E7A79FE8B581E689BFE58C85E58D8FE4BC9AE59CA8E4BAACE58FACE5BC80E7A791E68A80E8BF9BE6ADA5E5A596E380813C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4B893E5AEB6E8AF84E5AEA1E4BC9AE59CA8E4BAACE4B8BEE8A18CE38082E4B8ADE5BBBAE7A79FE58D8FE4BC9AE995BFE58898E883BDE69687E38081E5B8B8E58AA1E589AFE4BC9AE995BFE596BBE8BFBAE7A78BE38081E4B8ADE5BBBAE680BBE585ACE58FB8E68A80E69CAFE4B8ADE5BF83E589AFE680BBE5B7A5E7A88BE5B888E69E97E586B0E38081E58C97E4BAACE5A5A5E5AE87E6A8A1E69DBFE69C89E99990E585ACE58FB8E680BBE7BB8FE79086E883A1E581A5E38081E58C97E4BAACE6989FE6B2B3E4BABAE696BDE5B7A5E68A80E69CAFE69C89E99990E585ACE58FB8E680BBE7BB8FE79086E5A79CE4BCA0E5BA93E38081E58C97E4BAACE79B9BE6988EE5BBBAE8BEBEE5B7A5E7A88BE68A80E69CAFE69C89E99990E585ACE58FB8E68A80E69CAFE7BB8FE79086E6AEB5E6988EE68B85E4BBBBE6ADA4E6ACA1E8AF84E5AEA1E4BC9AE4B893E5AEB6EFBC8CE4BC9AE8AEAEE68EA8E4B8BEE596BBE8BFBAE7A78BE4B8BAE4B893E5AEB6E8AF84E5AEA1E7BB84E7BB84E995BFE38082E69CACE6ACA1E4B893E5AEB6E8AF84E5AEA1E4BC9AE58886E4B8BAE4B8A4E4B8AAE78EAFE88A82EFBC9AE4B880E698AFE58D8FE4BC9AE7A791E68A80E8BF9BE6ADA5E5A596E79A84E8AF84E98089EFBC8CE4BA8CE698AF3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE7A7B0E58FB7E79A84E8AF84E5AEA1E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE58898E883BDE69687E4BC9AE995BFE59CA8E887B4E8BE9EE4B8ADE59B9EE9A1BEE4BA86E8A18CE4B89AE79A84E8B5B7E6BA90E5928CE58F91E5B195E58E86E7A88BEFBC8CE59091E4B88EE4BC9AE4B893E5AEB6E4BB8BE7BB8DE4BA86E58D8FE4BC9AE8818CE883BDE4B88EE8BF91E69C9FE5BC80E5B195E79A84E5B7A5E4BD9CE38082E4BB96E68C87E587BAEFBC8CE4B889E58D81E5A49AE5B9B4E69DA5EFBC8CE8A18CE4B89AE58F91E5B195E4BB8EE697A0E588B0E69C89EFBC8CE4BB8EE5B08FE588B0E5A4A7EFBC8C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E323031343C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5B9B4E585A8E59BBDE5BBBAE7AD91E789A9E8B584E7A79FE8B581E689BFE58C85E694B6E585A5E5B7B2E8B685E8BF873C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E333837303C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4BABFE58583EFBC8CE789A9E8B584E5AD98E9878F3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E342E383C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4BABFE590A8EFBC8CE8A784E6A8A1E4BBA5E4B88AE4BC81E4B89AE8BEBEE588B03C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E343C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4B887E5AEB6E38082E4BB8AE5B9B4E7A798E4B9A6E5A484E8B5B0E8AEBFE8B083E7A094E4BA863C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E31313C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4B8AAE79C81E5B8823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E38303C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5A49AE5AEB6E4BC81E4B89AEFBC8CE58F91E78EB0E5889BE696B0E883BDE58A9BE5BCB1EFBC8CE7A791E68A80E6B0B4E5B9B3E4BD8EEFBC8CE7BB8FE890A5E7AEA1E79086E6A8A1E5BC8FE890BDE5908EE5B7B2E68890E4B8BAE588B6E7BAA6E8A18CE4B89AE5928CE4BC81E4B89AE58F91E5B195E79A84E887B4E591BDE79FADE69DBFE38082E989B4E4BA8EE8BF99E6A0B7E79A84E8838CE699AFEFBC8CE58D8FE4BC9AE8AEBEE7AB8BE7A791E68A80E8BF9BE6ADA5E5A596EFBC8CE697A8E59CA8E5BC95E5AFBCE4BC81E4B89AE9878DE8A786E7A791E68A80E5889BE696B0EFBC8CE68F90E58D87E5B882E59CBAE7AB9EE4BA89E58A9BE38082E58D8FE4BC9AE5B086E4BBA5E6ADA4E4B8BAE68A93E6898BEFBC8CE5BBBAE7AB8BE581A5E585A8E8A18CE4B89AE7A791E68A80E5889BE696B0E69CBAE588B6EFBC8CE68EA8E58AA8E8A18CE4B89AE8BDACE59E8BE58D87E7BAA7E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE8AF84E5AEA1E4BC9AE4B88AEFBC8CE4B8ADE5BBBAE7A79FE58D8FE5B8B8E58AA1E589AFE7A798E4B9A6E995BFE6B288E995BFE7949FE9A696E58588E59091E8AF84E5AEA1E7BB84E6B187E68AA5E4BA86E59084E9A1B9E79BAEE59FBAE69CACE68385E586B5E4B88EE8AF84E58886E7BB86E58899EFBC8CE7BB8FE8BF87E7A798E4B9A6E5A484E5889DE5AEA1EFBC8CE585B1E69C893C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E353C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4B8AAE794B3E68AA5E9A1B9E79BAEE8BF9BE585A5E69C80E7BB88E4B893E5AEB6E8AF84E5AEA1E998B6E6AEB5E38082E99A8FE5908EEFBC8CE59084E9A1B9E79BAEE4B8BBE5AEA1E4B893E5AEB6E58886E588ABE5B0B1E59084E887AAE4B8BBE5AEA1E9A1B9E79BAEE58F91E8A1A8E6848FE8A781EFBC8CE4B880E887B4E8AEA4E4B8BAE585A5E59BB4E9A1B9E79BAEE4BBA3E8A1A8E4BA86E59084E887AAE9A286E59F9FE79A84E8BE83E9AB98E7A791E68A80E6B0B4E5B9B3EFBC8CE68EA8E5B9BFE5898DE699AFE5B9BFE99894E38082E4BD86E5908CE697B6E69C89E79D80E887AAE8BAABE5BA94E794A8E79A84E5B180E99990E680A7EFBC8CE5B88CE69C9BE4BB8AE5908EE58AA0E4BBA5E694B9E8BF9BE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE69CACE79D80E585ACE5B9B3E38081E585ACE6ADA3E38081E585ACE5BC80E79A84E58E9FE58899EFBC8CE7A789E79D80E689BFE5898DE590AFE5908EE38081E9BC93E58AB1E5BC95E5AFBCE79A84E5AE97E697A8EFBC8C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E363C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4BD8DE4B893E5AEB6E5B0B1E59084E9A1B9E79BAEE68A80E69CAFE5889BE696B0E38081E7BB8FE6B58EE7A4BEE4BC9AE69588E79B8AE38081E68EA8E58AA8E7A791E68A80E8BF9BE6ADA5E7AD89E68C87E6A087E8BF9BE8A18CE68993E58886E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE596BBE8BFBAE7A78BE7BB84E995BFE69C80E5908EE5AEA3E5B883EFBC8CE69CACE6ACA1E58F82E4B88EE4B893E5AEB6E8AF84E5AEA1E79A843C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223E353C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE4B8AAE9A1B9E79BAEE58886E695B0E59D87E5A484E4BA8E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE4BC98E7A7803C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE6A1A3EFBC8CE585A8E983A8E88EB7E5BE97E4B880E7AD89E5A596E38082E5A5B9E8A1A8E7A4BAEFBC8C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223E353C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223EE4B8AAE9A1B9E79BAEE59D87E88EB7E5BE97E4B880E7AD89E5A596EFBC8CE4BBA3E8A1A8E4BA86E8A18CE4B89AE4B893E5AEB6E5AFB9E585A5E59BB4E9A1B9E79BAEE79A84E9AB98E5BAA6E8AEA4E58FAFEFBC8CE8A1A8E8BEBEE4BA86E5AFB9E8A18CE4B89AE4BC81E4B89AE58AA0E5BCBAE5889BE696B0E883BDE58A9BE5BBBAE8AEBEE79A84E5B88CE58680E38082E5908CE697B6EFBC8CE69CACE6ACA1E8AF84E98089E6B4BBE58AA8E4B99FE698AFE5AFB9E7A798E4B9A6E5A484E5B7A5E4BD9CE79A84E4B880E6ACA1E68C87E5AFBCEFBC8CE69C89E588A9E4BA8EE58D8FE4BC9AE5B7A5E4BD9CE79A84E4B88DE696ADE694B9E8BF9BE5928CE5AE8CE59684E38082E5B88CE69C9BE4BBA5E7A791E68A80E5A596E9A1B9E8AF84E5AEA1E4B8BAE5A591E69CBAEFBC8CE68EA8E58AA8E8A18CE4B89AE7A791E68A80E6B0B4E5B9B3E8BF88E4B88AE696B0E58FB0E998B6E380823C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C696D6720616C743D2222207372633D22687474703A2F2F7777772E35316469616F6C616E2E636F6D2E636E2F636F6E74656E742F6B696E64656469746F722F61747461636865642F696D6167652F32303135313131332F32303135313131333133343035305F323731332E706E6722202F3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE7ACACE4BA8CE9A1B9E8AEAEE7A88BE698AFE5AFB9E6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE794B3E68AA5E79A843C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE7A7B0E58FB7E8BF9BE8A18CE4B893E5AEB6E8AF84E5AEA1E38082E6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE7A798E4B9A6E995BFE596BBE683A0E4B89AE4BB8BE7BB8DE4BA86E697A0E994A1E5B882E5908AE7AFAEE4BAA7E4B89AE58E86E58FB2E6B2BFE99DA9E5928CE58F91E5B195E6A682E586B5EFBC8CE4BB96E8A1A8E7A4BAEFBC8CE79BAEE5898DE59BBDE58685E59CA8E794A8E5908AE7AFAEE4BF9DE69C89E9878FE5B7B2E8BEBE3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3135303C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4B887E58FB0E4BBA5E4B88AEFBC8CE4BB85E697A0E994A1E5908AE7AFAEE79A84E99480E594AEE9878FE5B0B1E58DA0E68DAEE68891E59BBDE5908AE7AFAEE5B882E59CBAE79A84E58D8AE5A381E6B19FE5B1B1EFBC8CE587BAE58FA3E9A29DE58DA0E588B0E585A8E59BBDE79A843C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3730253C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4BBA5E4B88AEFBC8CE696B0E4BAA7E59381E79A84E68A95E694BEE58DA0E68DAEE585A8E59BBDE79A843C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3930253C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EEFBC8CE59BBDE58685E5A4963C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3935253C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE4BBA5E4B88AE9878DE5A4A7E5B7A5E7A88BE4BDBFE794A8E79A84E5908AE7AFAEE587BAE887AAE697A0E994A1E38082E99288E5AFB9E5908AE7AFAEE4BD9CE4B89AE78EAFE5A283E585B7E69C89E58DB1E999A9E680A7E5BCBAE38081E4BA8BE69585E9A291E58F91E79A84E78EB0E78AB6EFBC8CE59CA8E697A0E994A1E4B893E997A8E68890E7AB8BE4BA86E585A8E59BBDE594AFE4B880E4B880E5AEB6E4BBA5E5908AE7AFAEE8A18CE4B89AE591BDE5908DE79A84E4B893E4B89AE58D8FE4BC9AEFBC8C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE68EA8E8BF9BE5908AE7AFAEE8A18CE4B89AE694B9E99DA9E38081E5889BE696B0E4B88EE58F91E5B195EFBC8CE58AA0E5BCBAE8A18CE4B89AE887AAE5BE8BE7AEA1E79086EFBC8CE690ADE5BBBAE4BC81E4B89AE4B88EE694BFE5BA9CE997B4E6A1A5E6A281E4B88EE7BABDE5B8A6EFBC8CE4BF83E8BF9BE5908AE7AFAEE8A18CE4B89AE68C81E7BBADE581A5E5BAB7E58F91E5B1953C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE38082E6ADA4E5A496EFBC8CE697A0E994A1E79A84E5908AE7AFAEE4BC81E4B89AE8BF98E58F82E4B88EE4BA86E8AFA5E4BAA7E59381E59BBDE5AEB6E6A087E58786E79A84E588B6E5AE9AEFBC8CE58585E58886E4BD93E78EB0E4BA86E697A0E994A1E5908AE7AFAEE4BC81E4B89AE59CA8E8A18CE4B89AE79A84E4BBA3E8A1A8E680A7E5928CE5BDB1E5938DE58A9BE38082E585A8E59BBDE5908AE7AFAEE9BE99E5A4B4E4BC81E4B89AE697A0E994A1E5B882E79A84E794B3E994A1E69CBAE6A2B0E585ACE58FB8E680BBE7BB8FE79086E590B4E69DB0E8A1A8E7A4BAEFBC8CE697A0E994A1E5908AE7AFAEE4BC81E4B89AE59CA83C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE8B5B0E587BAE58EBB3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE79A84E8BF87E7A88BE4B8ADEFBC8CE58F97E588B0E983A8E58886E6ACA7E7BE8EE4BC81E4B89AE79A84E681B6E6848FE68E92E68CA4EFBC8CE4B8BAE6ADA4E68891E696B9E7A7AFE69E81E5BA94E8AF89E5B9B6E8839CE8AF89EFBC8CE6B5B7E5A496E7BBB4E69D83E58F96E5BE97E4BA86E696B0E7AA81E7A0B4EFBC8CE4B8BAE7BBB4E68AA4E585A8E59BBDE5908AE7AFAEE8A18CE4B89AE79A84E695B4E4BD93E588A9E79B8AEFBC8CE68EA8E58AA8E4BAA7E883BDE8BE93E587BAE5BC80E4BA86E5A5BDE5A4B4E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A31392E3270743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5AEA1E5AE9AE7BB84E6A0B9E68DAEE6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE794B3E8AFB7E68E88E4BA883C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE79A84E68AA5E5918AE58F8AE694AFE69291E680A7E99984E4BBB6E69D90E69699EFBC8CE8BF9BE8A18CE4BA86E4B893E5AEB6E8B4A8E8AFA2E38082E7BB8FE8BF87E58585E58886E88083E89991EFBC8CE8AEA4E4B8BAE794B3E68AA5E58D95E4BD8DE68F90E4BAA4E79A84E69D90E69699E58685E5AEB9E7BF94E5AE9EEFBC8CE695B0E68DAEE585A8E99DA2EFBC8CE697A0E994A1E5908AE7AFAEE59CA8E8A18CE4B89AE4BBA3E8A1A8E680A7E5BCBAEFBC8CE5B882E59CBAE58DA0E69C89E78E87E9AB98EFBC8CE59CA8E4BF83E8BF9BE8A18CE4B89AE58F91E5B195E696B9E99DA2E5819AE587BAE4BA86E7AA81E587BAE8B4A1E78CAEE38082E8AF84E5AEA1E4B893E5AEB6E4B880E887B4E5908CE6848FE68E88E4BA88E697A0E994A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809C3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE5908AE7AFAEE4B98BE4B9A13C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223EE2809D3C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A313270743B223EE7A7B0E58FB7E38082E5908CE697B6E5BBBAE8AEAEEFBC8CE5BD93E59CB0E4BC81E4B89AE8A681E4BE9DE68998E8A18CE4B89AE58D8FE4BC9AEFBC8CE59CA8E68F90E58D87E4BAA7E59381E8B4A8E9878FE38081E68F90E9AB98E696BDE5B7A5E5AE89E585A8E79B91E7AEA1E6B0B4E5B9B3E38081E8A784E88C83E4BC81E4B89AE8A18CE4B8BAE7AD89E696B9E99DA2E58F91E68CA5E69BB4E5A4A7E4BD9CE794A8EFBC8CE4BF83E8BF9BE58CBAE59F9FE7BB8FE6B58EE4B88EE7A4BEE4BC9AE79A84E8B7A8E8B68AE5BC8FE58F91E5B195E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793A48656C7665746963613B666F6E742D73697A653A313270743B223E3C2F7370616E3E200D0A3C2F703E0D0A3C703E0D0A09266E6273703B0D0A3C2F703E, '271', '00001');
INSERT INTO `news` VALUES ('6af6f41d-1033-405c-8e96-cd3e1e95cc98', '无锡被评为中国“吊篮之乡”', '', '\0', null, '2016-01-15 00:00:00', '', 0x3C70207374796C653D22746578742D616C69676E3A63656E7465723B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236363636363633B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B223EE69DA5E6BA90EFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236363636363633B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B223EE4B8ADE59BBDE8B4A8E9878FE696B0E997BBE7BD913C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236363636363633B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D616C69676E3A6C6566743B746578742D696E64656E743A3070743B6D617267696E2D6C6566743A3070743B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B266E6273703B266E6273703B266E6273703B3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE69CACE68AA5E8AEAF266E6273703BE697A5E5898DEFBC8C32303135E5B9B4E585A8E59BBDE5BBBAE7AD91E789A9E8B584E7A79FE8B581E689BFE58C85E8A18CE4B89AE5B9B4E4BC9AE59CA8E6B19FE88B8FE697A0E994A1E58FACE5BC80E38082E4BC9AE4B88AEFBC8CE4B8ADE59BBDE59FBAE5BBBAE789A9E8B584E7A79FE8B581E689BFE58C85E58D8FE4BC9AE68E88E4BA88E697A0E994A1E5B882E2809CE5908AE7AFAEE4B98BE4B9A1E2809DE7A7B0E58FB7E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D616C69676E3A6C6566743B746578742D696E64656E743A3070743B6D617267696E2D6C6566743A3070743B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B266E6273703B266E6273703B266E6273703BE9AB98E7A9BAE4BD9CE4B89AE5908AE7AFAEEFBC8CE7B4A0E69C89E2809CE585A8E79083E79C8BE4B8ADE59BBDE38081E4B8ADE59BBDE79C8BE6B19FE88B8FE38081E6B19FE88B8FE79C8BE697A0E994A1E2809DE79A84E7BE8EE8AA89E38082E68DAEE4BA86E8A7A3EFBC8CE68891E59BBDE5B9B4E4BAA7E9AB98E7A9BAE4BD9CE4B89AE5908AE7AFAEE8B685E8BF873130E4B887E58FB0EFBC8CE5B7B2E68890E4B8BAE585A8E79083E5908AE7AFAEE588B6E980A0E7ACACE4B880E5A4A7E59BBDEFBC8CE585B6E4B8ADE59BBDE58685E5A496393525E4BBA5E4B88AE9878DE782B9E5B7A5E7A88BE4BDBFE794A8E79A84E5908AE7AFAEE587BAE887AAE6B19FE88B8FEFBC8CE585A8E59BBD393025E4BBA5E4B88AE79A84E9AB98E7A9BAE4BD9CE4B89AE5908AE7AFAEE696B0E4BAA7E59381E587BAE887AAE6B19FE88B8FEFBC8CE587BAE58FA3E9A29DE79A84383025E587BAE887AAE6B19FE88B8FE38082E8808CE697A0E994A1E58899E698AFE585A8E79083E8AFA5E8A18CE4B89AE4BAA7E59381E79A84E69C80E5A4A7E4BAA7E587BAE59CB0E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D616C69676E3A6C6566743B746578742D696E64656E743A3070743B6D617267696E2D6C6566743A3070743B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E266E6273703B266E6273703B266E6273703B266E6273703BE694B9E99DA9E5BC80E694BEE4BBA5E69DA5EFBC8CE697A0E994A1E58588E5908EE6B68CE78EB0E587BAE5B08FE5A4A9E9B985E38081E794B3E994A1E38081E5A4A9E9809AE38081E58D8EE7A791E38081E99B84E5AE87E38081E5BCBAE68192E38081E587A4E9B8BFE7AD89E79FA5E5908DE5908AE7AFAEE7949FE4BAA7E59381E7898CE38082E697A0E994A1E5908AE7AFAEE59CA8E8A18CE4B89AE9878CE4BBA3E8A1A8E680A7E5BCBAEFBC8CE5B882E59CBAE58DA0E69C89E78E87E9AB98EFBC8CE59CA8E4BF83E8BF9BE8A18CE4B89AE58F91E5B195E696B9E99DA2E4BD9CE587BAE4BA86E7AA81E587BAE8B4A1E78CAEE38082E4BB8AE5B9B43131E69C8838E697A5EFBC8CE6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE59CA8E697A0E994A1E6ADA3E5BC8FE68890E7AB8BEFBC8CE79C81E586853637E5AEB6E79BB8E585B3E8A18CE4B89AE4BC81E4B89AE68890E4B8BAE58D8FE4BC9AE9A696E689B9E4BC9AE59198E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B636F6C6F723A233030303030303B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E, '157', '00001');
INSERT INTO `news` VALUES ('88338a3f-7239-4db5-886c-368ee4e82d36', '中国工程机械科技、质量与标准化发展论坛在京隆重举办', '', '\0', null, '2015-09-25 00:00:00', '', 0x3C7020636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A313470743B223E266E6273703B266E6273703B266E6273703B20323031353C7370616E3EE5B9B43C2F7370616E3E3C7370616E3E393C2F7370616E3E3C7370616E3EE69C883C2F7370616E3E3C7370616E3E32343C2F7370616E3E3C7370616E3EE697A5EFBC8CE4B8ADE59BBDE5B7A5E7A88BE69CBAE6A2B0E8A18CE4B89AE59CA8E58C97E4BAACE99A86E9878DE4B8BEE58A9EE4BA86E2809CE7A791E68A80E38081E8B4A8E9878FE4B88EE6A087E58786E58C96E58F91E5B195E8AEBAE59D9BE2809DE38082E69DA5E887AAE585A8E59BBDE59084E59CB0E79A84E5B7A5E7A88BE69CBAE6A2B0E8A18CE4B89AE79A843C2F7370616E3E3C7370616E3E3130303C2F7370616E3E3C7370616E3EE4BD99E5908DE4B893E5AEB6E38081E5ADA6E88085E5928CE4BC81E4B89AE5AEB6E9BD90E8819AE4B880E5A082EFBC8CE585B1E5908CE58886E69E90E5BD93E5898DE5B7A5E7A88BE69CBAE6A2B0E8A18CE4B89AE79A84E58F91E5B195E78EB0E78AB6E4B88EE997AEE9A298EFBC8CE7A094E7A9B6E68EA2E7B4A2E5B7A5E7A88BE69CBAE6A2B0E8A18CE4B89AE79A84E58F91E5B195E696B9E59091E4B88EE68898E795A5E380823C2F7370616E3E3C2F7370616E3E200D0A3C2F703E, '258', '00001');
INSERT INTO `news` VALUES ('9e012464-fbf1-41af-8781-50a2b2e2fe08', '我国高空作业平台行业发展现状及未来发展方向分析', '', '\0', null, '2016-03-01 00:00:00', '', 0x3C70207374796C653D22746578742D616C69676E3A63656E7465723B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A31302E3570743B223EE69DA5E6BA90EFBC9AE4B8ADE59BBDE8B5B7E9878DE69CBAE6A2B0E7BD913C2F7370616E3E3C7370616E207374796C653D22666F6E742D66616D696C793AE5AE8BE4BD933B666F6E742D73697A653A31302E3570743B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE69C80E8BF91E587A0E5B9B4EFBC8CE68891E59BBDE9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E8A18CE4B89AE58F91E5B195E8BF85E78C9BEFBC8CE4BD9CE4B8BAE5908EE8B5B7E4B98BE7A780EFBC8CE59CA8E4B880E78987E4BD8EE8BFB7E79A84E5B7A5E7A88BE69CBAE6A2B0E5B882E59CBAEFBC8CE698BEE5BE97E6A0BCE5A496E7AA81E587BAE38082E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E7A79FE8B581E5B882E59CBAE8BF91E587A0E5B9B4E4B99FE59188E9AB98E9809FE58F91E5B195E68081E58ABFEFBC8CE68DAEE59BBDE99985E9AB98E7A9BAE4BD9CE4B89AE88194E79B9FE7BB9FE8AEA1EFBC8CE887B33C7370616E3E323031343C2F7370616E3E3C7370616E3EE5B9B4E5BA95E59BBDE58685E4BB8EE4BA8BE9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E7A79FE8B581E79A84E4BC81E4B89AE7BAA63C2F7370616E3E3C7370616E3E3135302D3230303C2F7370616E3E3C7370616E3EE5AEB6EFBC8CE794A8E4BA8EE7A79FE8B581E79A84E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E695B0E9878FE7BAA63C2F7370616E3E3C7370616E3E31303030303C2F7370616E3E3C7370616E3EE58FB0E5B7A6E58FB3E38082E4B8ADE59BBDE9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E69CAAE69DA5E58F91E5B195E5898DE699AFE889AFE5A5BDEFBC8CE59BBDE58685E5B882E59CBAE7A9BAE997B4E5B7A8E5A4A7EFBC8CE6B395E8A784E6ADA3E59CA8E98090E6ADA5E5AE8CE59684EFBC8CE5AE89E585A8E6848FE8AF86E98090E6B890E58AA0E5BCBAE38082E4BAA7E59381E7B1BBE59E8BE794B1E4B8ADE4BD8EE7ABAFE4BAA7E59381E98090E6B890E59091E9AB98E7ABAFE4BAA7E59381E58F91E5B195EFBC8CE8B4A8E9878FE4B99FE59CA8E98090E6ADA5E68F90E9AB98E38082E79BAEE5898DE98187E588B0E79A84E9AB98E7A9BAE7A79FE8B581E8A18CE4B89AE681B6E680A7E4BBB7E6A0BCE7AB9EE4BA89EFBC8CE4BC81E4B89AE694B6E6ACBEE59BB0E99ABEEFBC8CE4BC81E4B89AE697A5E5B8B8E8BF90E890A5EFBC8CE9AB98E7A9BAE8BDA6E4BF9DE585BBE58F8AE9AB98E7A9BAE4BD9CE4B89AE9A286E59F9FE6B395E5BE8BE6B395E8A784E7AD89E997AEE9A298E4BE9DE697A7E698AFE59BB0E689B0E79D80E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E8A18CE4B89AE38082E79BAEE5898DE9AB98E7A9BAE4BD9CE4B89AE8A18CE4B89AE6ADA3E99DA2E4B8B4E5B7A8E5A4A7E79A84E69CBAE98187E5928CE68C91E68898EFBC8CE5AEA2E688B7E5AFB9E9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E79A84E99C80E6B182E4B88DE696ADE5A29EE58AA0EFBC8CE5B882E59CBAE6BD9CE58A9BE5B7A8E5A4A7EFBC8CE4BD86E5908CE697B6E681B6E680A7E79A84E4BBB7E6A0BCE7AB9EE4BA89E38081E5AEA2E688B7E59B9EE6ACBEE99ABEE4B99FE59CA8E59BB0E689B0E79D80E5BE88E5A49AE4BC81E4B89AEFBC8CE4B8BAE4BA86E69BB4E5A5BDE59CB0E8A784E88C83E8A18CE4B89AE7A7A9E5BA8FEFBC8CE68891E59BBDE79A84E9AB98E7A9BAE4BD9CE4B89AE8BDA6E7A79FE8B581E4BC81E4B89AE4B99FE887AAE58F91E68890E7AB8BE4BA86E4B8ADE59BBDE9AB98E7A9BAE8BDA6E5A4A7E88194E79B9FEFBC8CE88194E79B9FE69CACE79D80E585ACE6ADA3E38081E69C8DE58AA1E79A84E58E9FE58899EFBC8CE5B086E4B8BAE88194E79B9FE68890E59198E5858DE8B4B9E68F90E4BE9BE69C80E696B0E79A84E59BBDE58685E5A496E8A18CE4B89AE58F91E5B195E58AA8E59091E38081E69C80E696B0E79A84E9AB98E7A9BAE8AEBEE5A487E68A80E69CAFE4BFA1E681AFE38081E58D8FE8B083E88194E79B9FE4BC81E4B89AE997B4E4B88DE585ACE5B9B3E79A84E4BBB7E6A0BCE7AB9EE4BA89EFBC8CE4B8BAE88194E79B9FE68890E59198E68F90E4BE9BE8AEBEE5A487E7BBB4E68AA4E4BF9DE585BBE696B9E99DA2E79A84E4B893E4B89AE79FA5E8AF86E5928CE69C8DE58AA1E7AD89E38082E58F82E58AA0E88194E79B9FE79A84E68890E59198E58D95E4BD8DE8A1A8E7A4BAE5B086E689BFE8AFBAE981B5E5AE88E8A18CE4B89AE8A784E88C83EFBC8CE4B88DE58F82E4B88EE8A18CE4B89AE681B6E680A7E4BBB7E6A0BCE7AB9EE4BA89E380823C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE9AB98E7A9BAE4BD9CE4B89AE4BC81E4B89AE99DA2E4B8B4E78EB0E78AB6E4B98BEFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE681B6E680A7E4BBB7E6A0BCE7AB9EE4BA893C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E79A84E587BAE78EB0E8A7A3E586B3E4BA86E9AB98E7A9BAE696BDE5B7A5E4BABAE59198E79A84E5AE89E585A8E997AEE9A298EFBC8CE5A4A7E5A4A7E68F90E9AB98E4BA86E9AB98E7A9BAE4BD9CE4B89AE79A84E69588E78E87EFBC8CE88A82E7BAA6E68890E69CACEFBC8CE9998DE4BD8EE6B688E88097E38082E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E7A79FE8B581E59CA8E58C97E4B88AE5B9BFE6B7B1E7AD89E59CB0E5B7B2E7BB8FE69C89E4BA86E5A49AE5B9B4E79A84E58F91E5B195EFBC8CE4BD86E698AFE7BAB5E8A782E585A8E59BBDE4BB8DE784B6E5A484E4BA8EE8908CE88ABDE78AB6E68081EFBC8CE5B882E59CBAE6BD9CE58A9BE5B7A8E5A4A7E38082E79BAEE5898DE5B882E59CBAE4B88AE59084E7A78DE9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E889AFE88EA0E4B88DE9BD90EFBC8CE7AB9EE4BA89E697A5E8B68BE683A8E78388EFBC8CE5B7B2E7BB8FE587BAE78EB0E5A49AE5AEB6E8AEBEE5A487E7A79FE8B581E59586E59CA8E5908CE4B880E4B8AAE5B7A5E59CB0E9A1B9E79BAEE4B88AE681B6E6848FE7AB9EE4BBB7E79A84E78EB0E8B1A1EFBC8CE4B88DE4BB85E68D9FE5AEB3E4BA86E7A79FE8B581E59586E69CACE8BAABE79A84E588A9E79B8AEFBC8CE4B99FE68D9FE5AEB3E4BA86E5AEA2E688B7E79A84E588A9E79B8AE38082E681B6E680A7E7AB9EE4BA89E980A0E68890E79A84E98787E8B4ADE4B88DE5AE89E585A8E8AEBEE5A487E68896E88085E5BFBDE8A786E7BBB4E4BFAEE4BF9DE585BBE7AD89E69C8DE58AA1E78EAFE88A82E980A0E68890E79A84E4BA8BE69585E4B99FE697B6E69C89E880B3E997BBE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4B88EE585B6E59084E59CB0E8AEBEE5A487E7A79FE8B581E59586E983BDE8819AE784A6E69F90E4B880E4B8AAE5B7A5E59CB0EFBC8CE8BF9BE8A18CE681B6E6848FE7AB9EE4BA89EFBC8CE4B88DE5A682E6B7B1E88095E887AAE5B7B1E79A84E58CBAE59F9FE5B882E59CBAEFBC8CE8AEA9E58CBAE59F9FE58685E5B882E59CBAE5BFABE9809FE8AEA4E8AF86E588B0E4B893E4B89AE9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E79A84E5AE89E585A8E680A7E5928CE7BB8FE6B58EE680A7EFBC8CE5BC80E58F91E5928CE5BC95E9A286E69CACE59CB0E5B882E59CBAE5BFABE9809FE58F91E5B195EFBC8CE7AD89E58CBAE59F9FE5B882E59CBAE68890E7869FE5908EE4BC81E4B89AE5B0B1E698AFE8AFA5E5B882E59CBAE69C80E5A4A7E79A84E58F97E79B8AE88085E38082E8A18CE4B89AE7A79FE8B581E4BC81E4B89AE58FAAE69C89E4BBA5E68F90E4BE9BE5AEA2E688B7E4BC98E8B4A8E69C8DE58AA1E4B8BAE7BB8FE890A5E79086E5BFB5EFBC8CE794A8E69C8DE58AA1E5BE81E69C8DE5AEA2E688B7EFBC8CE8B5A2E5BE97E5B882E59CBAEFBC8CE6898DE883BDE4BF83E8BF9BE695B4E4B8AAE8A18CE4B89AE79A84E581A5E5BAB7E58F91E5B195E380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE9AB98E7A9BAE4BD9CE4B89AE4BC81E4B89AE99DA2E4B8B4E78EB0E78AB6E4B98BEFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4BC81E4B89AE697A5E5B8B8E8BF90E890A5E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E7A79FE8B581E5B882E59CBAE5B882E59CBAE8BF91E587A0E5B9B4E69DA5E58F91E5B195E8BF85E78C9BEFBC8CE5B882E59CBAE4BF9DE69C89E9878FE4BB8E3C7370616E3E323031323C2F7370616E3E3C7370616E3EE5B9B4E5B9B4E5BA953C2F7370616E3E3C7370616E3E333530303C2F7370616E3E3C7370616E3EE58FB0E588B03C2F7370616E3E3C7370616E3E323031333C2F7370616E3E3C7370616E3EE5B9B4E5B9B4E5BA953C2F7370616E3E3C7370616E3E373030303C2F7370616E3E3C7370616E3EE58FB0EFBC8C3C2F7370616E3E3C7370616E3E323031343C2F7370616E3E3C7370616E3EE5B9B4E5BA953C2F7370616E3E3C7370616E3E31353030303C2F7370616E3E3C7370616E3EE58FB0EFBC8CE5868DE588B0E78EB0E59CA83C2F7370616E3E3C7370616E3E32303030303C2F7370616E3E3C7370616E3EE5A49AE58FB0EFBC8CE68EA5E4B88BE69DA5E8A18CE4B89AE8BF98E4BC9AE7BBA7E7BBADE5BFABE9809FE58F91E5B195E38082E4B8ADE59BBDE69CAAE69DA5E88081E9BE84E58C96E78EB0E8B1A1E4BC9AE99D9EE5B8B8E4B8A5E9878DEFBC8CE69CAAE69DA53C2F7370616E3E3C7370616E3E32303C2F7370616E3E3C7370616E3EE5B9B4E4B8ADE59BBDE58AB3E58AA8E58A9BE4BABAE58FA3E5B086E5878FE5B0913C2F7370616E3E3C7370616E3E313C2F7370616E3E3C7370616E3EE4B8AAE4BABFEFBC8CE4BABAE58A9BE68890E69CACE5B086E4BC9AE8B68AE69DA5E8B68AE9AB98EFBC8CE8808CE4BB8EE4BA8BE9AB98E7A9BAE58DB1E999A9E4BD9CE4B89AE4BABAE695B0E4BC9AE5A4A7E5B985E5878FE5B091E38082E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E8A7A3E586B3E4BA86E5AE89E585A8E5928CE69588E79B8AE4B8A4E4B8AAE997AEE9A298EFBC8CE68980E4BBA5E9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E5B882E59CBAE69CAAE69DA5E58F91E5B195E698AFE4B990E8A782E79A84E38082E79BAEE5898DE4B8ADE59BBDE9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E7A79FE8B581E4BC81E4B89AE8BF90E890A5E99DA2E5AFB9E79A84E997AEE9A298E69C89EFBC9AE4B880E698AFE4BC81E4B89AE9809AE8BF87E89E8DE8B584E7A79FE8B581E8B4ADE8BDA6EFBC8CE5908EE69C9FE79A84E8BF98E6ACBEE58E8BE58A9BE5B7A8E5A4A7E38082E4BC81E4B89AE8AEBEE5A487E4B88DE5BE97E4B88DE8BF9EE8BDB4E8BF90E8BDACEFBC8CE698AFE681B6E680A7E4BBB7E6A0BCE7AB9EE4BA89E79A84E4BF83E59BA0E5928CE58AA3E8B4A8E5AEA2E688B7E69C8DE58AA1E79A84E6A0B9E6BA90EFBC8CE4BDBFE4BC81E4B89AE999B7E585A5E4B88DE889AFE5BEAAE78EAFE38082E4BA8CE698AFE4BC81E4B89AE4BABAE59198E79A84E7B4A0E8B4A8E997AEE9A298E38082E5BDB1E5938DE585ACE58FB8E58F91E5B195E79A84E59BA0E7B4A0E999A4E4BA86E8B584E98791EFBC8CE58FA6E5A496E4B880E4B8AAE59BA0E7B4A0E5B0B1E698AFE4BABAEFBC8CE4BC81E4B89AE4BABAE59198E79A84E7B4A0E8B4A8E5928CE883BDE58A9BE79BB4E68EA5E586B3E5AE9AE4BA86E4BC81E4B89AE79A84E8BF90E890A5E78AB6E586B5E38082E59BA2E9989FE4B89AE58AA1E79A84E68B93E5B195E883BDE58A9BEFBC8CE59BA2E9989FE79A84E5AEA2E688B7E69C8DE58AA1E6848FE8AF86E983BDE99D9EE5B8B8E9878DE8A681EFBC8CE68980E4BBA5E5A682E4BD95E58EBBE98089E68BA9E59088E98082E79A84E4BABAE58EBBE68A8AE585ACE58FB8E79A84E69C8DE58AA1E5928CE4B89AE58AA1E5819AE5A5BDEFBC8CE698AFE99D9EE5B8B8E99C80E8A681E9878DE8A786E79A84E997AEE9A298E380823C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE9AB98E7A9BAE4BD9CE4B89AE4BC81E4B89AE99DA2E4B8B4E78EB0E78AB6E4B98BEFBC9A3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A626F6C643B2220636C6173733D223135223EE4BC81E4B89AE69CAAE69DA5E58F91E5B195E696B9E590913C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B6261636B67726F756E643A236666666666663B2220636C6173733D2270223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE4BBB7E6A0BCE7AB9EE4BA89E698AFE5B882E59CBAE7BB8FE6B58EE697A0E58FAFE981BFE5858DE79A84E4BA8BE5AE9EEFBC8CE8808CE4BC81E4B89AE69BB4E5BA94E8AFA5E88083E89991E6808EE6A0B7E59CA8E5A4B9E7BC9DE4B8ADE6B182E7949FE5AD98EFBC8CE6808EE4B988E58EBBE68BBCE8B584E69CACEFBC8CE68BBCE4BAA7E59381EFBC8CE68BBCE69C8DE58AA1EFBC8CE68BBCE88090E58A9BEFBC8CE59CA8E58F91E5B195E5BD93E4B8ADE5819AE588B0E4B88EE4BC97E4B88DE5908CEFBC8CE68993E980A0E887AAE5B7B1E6A0B8E5BF83E7AB9EE4BA89E58A9BEFBC8CE4BB8EE8808CE59CA8E6BF80E78388E79A84E7AB9EE4BA89E4B8ADE884B1E9A296E8808CE587BAE380823C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E0D0A3C70207374796C653D22746578742D696E64656E743A323170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793A56657264616E613B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223EE79BAEE5898DE9AB98E7A9BAE4BD9CE4B89AE7A79FE8B581E8A18CE4B89AE4B8BBE8A681E5AEA2E688B7E8BF98E698AFE5BBBAE7AD91E585ACE58FB8EFBC8CE4BD86E5BA94E8AFA5E79C8BE588B0EFBC8CE9AB98E7A9BAE4BD9CE4B89AE5B9B3E58FB0E79A84E4BDBFE794A8E999A4E4BA86E5BBBAE7AD91E9A286E59F9FE8BF98E69C89E59586E4B89AE59CB0E4BAA7E38081E789A9E4B89AE7AD89E38082E79BAEE5898DE9AB98E7A9BAE4BD9CE4B89AE8BDA6E59CA8E59586E4B89AE59CB0E4BAA7E9A286E59F9FE8BF98E6B2A1E69C89E68EA8E5B9BFE5BC80E69DA5EFBC8CE5A682E69E9CE68EA8E5B9BFE5BC80E4BBA5E5908EEFBC8CE59586E4B89AE59CB0E4BAA7E5B086E4BC9AE698AFE9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A487E69C80E5A4A7E79A84E5B882E59CBAE38082E78EB0E59CA8E5BE88E5A49AE59586E4B89AE59CB0E4BAA7E696BDE5B7A5E4B8ADE8BF98E59CA8E99DA0E690ADE5BBBAE8849AE6898BE69EB6E7AD89E4BABAE5B7A5E696B9E6B395EFBC8CE69588E78E87E4BD8EEFBC8CE68890E69CACE9AB98EFBC8CE4B894E5AD98E59CA8E5AE89E585A8E99A90E682A3E38082E982A3E4B988E5A682E4BD95E59CA8E59586E4B89AE59CB0E4BAA7E9878CE68EA8E5B9BFE4B893E4B89AE9AB98E7A9BAE4BD9CE4B89AE8AEBEE5A4873C7370616E3E3F3C2F7370616E3E3C7370616E3EE59586E4B89AE59CB0E4BAA7E585B7E69C89E585B6E6B885E699B0E79A84E789B9E782B9EFBC8CE5A682E69F90E4B8AAE5A4A7E6A5BCE4BB8EE68B9BE68A95E6A087E59C9FE59CB0E5BC80E5A78BEFBC8CE5B0B1E883BDE6B885E6A59AE79C8BE587BAE5BBBAE7AD91E59586E38081E689BFE58C85E59586E5928CE8AEBEE8AEA1E58D95E4BD8DE698AFE593AAE5AEB6E38082E7A79FE8B581E4BC81E4B89AE58FAFE4BBA5E689BEE588B0E8AEBEE8AEA1E58D95E4BD8DEFBC8CE4BB8EE6BA90E5A4B4E4B88AE8BF9BE8A18CE6B29FE9809AEFBC8CE5918AE8AF89E4BB96E4BBACE58FAFE4BBA5E8A7A3E586B3E79A84E696BDE5B7A5E5B7A5E889BAE997AEE9A298E38082E5908CE697B6E58FAFE4BBA5E68A8AE59586E4B89AE59CB0E4BAA7E5928CE68890E7869FE79A84E5B7A5E4B89AE59CB0E4BAA7E5819AE995BFE69C9FE8A784E58C96EFBC8CE6AF94E696B9E8AFB4E6B1BDE8BDA6E5B7A5E58E82E78EB0E59CA8E698AFE8BDBBE8B584E4BAA7EFBC8CE8808CE9AB98E7A9BAE4BD9CE4B89AE8BDA6E7A79FE8B581E68890E69CACE6A0B8E7AE97E58FAFE8BEBEE58D81E5B9B4EFBC8CE8BF99E6A0B7E79A84E68890E69CACE6A0B8E7AE97E58FAFE4BBA5E5BE88E5A5BDE79A84E5B086E8B584E98791E59B9EE7ACBCE9A38EE999A9E9998DE4BD8EEFBC8CE4BC81E4B89AE588A9E6B6A6E78E87E68F90E9AB98E38082E68980E4BBA5EFBC8CE4B88DE8A681E68A8AE68980E69C89E79BAEE6A087E983BDE99481E5AE9AE59CA8E5BBBAE7AD91E585ACE58FB8EFBC8CE5BBBAE7AD91E585ACE58FB8E5B882E59CBAE7A1AEE5AE9EE5BE88E5A4A7EFBC8CE4BD86E4BC81E4B89AE8BF98E99C80E79C8BE588B0E8BF99E4B98BE5A496E79A84E5B882E59CBAE69BB4E5A4A7E380823C2F7370616E3E3C2F7370616E3E3C7370616E207374796C653D22666F6E742D7374796C653A6E6F726D616C3B666F6E742D66616D696C793AE5AE8BE4BD933B6261636B67726F756E643A236666666666663B636F6C6F723A233333333333333B666F6E742D73697A653A31302E3570743B666F6E742D7765696768743A6E6F726D616C3B223E3C2F7370616E3E0D0A3C2F703E, '152', '00001');
INSERT INTO `news` VALUES ('befe8e6b-4622-48be-b256-3af0a80e03f5', '公司简介', '\0', '\0', null, '2015-10-14 00:00:00', '后顾无忧是高空机械工程技术研究院有限公司（简称高研院）旗下关于高空作业产品销售及专业技术服务的电子商务平台。后顾无忧致力于为客户提供便捷的技术咨询及在线交易体验，通过手机客户端，提供卓越品质的商品和服务。 高研院是由国家工商行政总局核准的独立法人单位，是专业从事高空施工机械与工程技术研究的机构。其前身是江苏高空施工机械工程技术研究院有限公司，成立于2013年7月，具有国家质量技术监督部门颁发的“计量合格确认证书”。高研院是“江苏省高空机械吊篮协会”副会长单位', 0x3C703E0D0A093C6272202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E74657222207374796C653D22746578742D616C69676E3A63656E7465723B223E0D0A093C7370616E207374796C653D226C696E652D6865696768743A312E353B223E203C2F7370616E3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E74657222207374796C653D22746578742D616C69676E3A63656E7465723B223E0D0A093C623EE5908EE9A1BEE697A0E5BFA7E7AE80E4BB8B3C7370616E3E3C2F7370616E3E3C2F623E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E5908EE9A1BEE697A0E5BFA7E698AFE9AB98E7A9BAE69CBAE6A2B0E5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E999A2E69C89E99990E585ACE58FB8EFBC88E7AE80E7A7B0E9AB98E7A094E999A2EFBC89E69797E4B88BE585B3E4BA8EE9AB98E7A9BAE4BD9CE4B89AE4BAA7E59381E99480E594AEE58F8AE4B893E4B89AE68A80E69CAFE69C8DE58AA1E79A84E794B5E5AD90E59586E58AA1E5B9B3E58FB0E38082E5908EE9A1BEE697A0E5BFA7E887B4E58A9BE4BA8EE4B8BAE5AEA2E688B7E68F90E4BE9BE4BEBFE68DB7E79A84E68A80E69CAFE592A8E8AFA2E58F8AE59CA8E7BABFE4BAA4E69893E4BD93E9AA8CEFBC8CE9809AE8BF87E6898BE69CBAE5AEA2E688B7E7ABAFEFBC8CE68F90E4BE9BE58D93E8B68AE59381E8B4A8E79A84E59586E59381E5928CE69C8DE58AA1E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E9AB98E7A094E999A2E698AFE794B1E59BBDE5AEB6E5B7A5E59586E8A18CE694BFE680BBE5B180E6A0B8E58786E79A84E78BACE7AB8BE6B395E4BABAE58D95E4BD8DEFBC8CE698AFE4B893E4B89AE4BB8EE4BA8BE9AB98E7A9BAE696BDE5B7A5E69CBAE6A2B0E4B88EE5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E79A84E69CBAE69E84E38082E585B6E5898DE8BAABE698AFE6B19FE88B8FE9AB98E7A9BAE696BDE5B7A5E69CBAE6A2B0E5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E999A2E69C89E99990E585ACE58FB8EFBC8CE68890E7AB8BE4BA8E3C7370616E3E323031333C2F7370616E3EE5B9B43C7370616E3E373C2F7370616E3EE69C88EFBC8CE585B7E69C89E59BBDE5AEB6E8B4A8E9878FE68A80E69CAFE79B91E79DA3E983A8E997A8E9A281E58F91E79A84E2809CE8AEA1E9878FE59088E6A0BCE7A1AEE8AEA4E8AF81E4B9A6E2809DE38082E9AB98E7A094E999A2E698AFE2809CE6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE2809DE589AFE4BC9AE995BFE58D95E4BD8DE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E9AB98E7A094E999A2E6B187E99B86E4BA86E59BBDE58685E5A496E4BC97E5A49AE79FA5E5908DE4B893E5AEB6E58F8AE6A380E6B58BE38081E59FB9E8AEADE8A18CE4B89AE8B584E6B7B1E4B893E5AEB6EFBC8CE69C89E79A84E58F82E4B88EE4BA86E4BD8FE5BBBAE983A8E3808AE585B3E4BA8EE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE696BDE5B7A5E5AE89E585A8E79B91E7AEA1E79A84E7A094E7A9B6E3808BE7AD89E9878DE5A4A7E8AFBEE9A298EFBC9BE69C89E79A84E4BD9CE4B8BAE8A18CE4B89AE68A80E69CAFE69D83E5A881EFBC8CE89197E69C89E59084E7B1BBE4B893E4B89AE89197E4BD9CEFBC9BE69C89E79A84E58F82E4B88EE8BF87E3808AE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE3808BE38081E3808AE693A6E7AA97E69CBAE3808BE7AD893C7370616E3E31303C2F7370616E3EE5A49AE9A1B9E59BBDE5AEB6E6A087E58786E5928CE8A18CE4B89AE6A087E58786E79A84E8B5B7E88D89E4B88EE7BC96E588B6E5B7A5E4BD9CEFBC9BE69C89E79A84E689BFE68B85E79D80E59BBDE5AEB6E2809CE58D81E4B880E4BA94E2809DE38081E2809CE58D81E4BA8CE4BA94E2809DE7A791E68A80E694AFE69291E8AEA1E58892E9878DE782B9E9A1B9E79BAEEFBC8CE88EB7E5BE97E8BF87E59BBDE5AEB6E5BBBAE8AEBEE7A791E68A80E2809CE58D8EE5A48FE5A596E2809DEFBC9BE69C89E79A84E68BA5E69C89E5A49AE9A1B9E69CACE4B893E4B89AE59BBDE5AEB6E58F91E6988EE4B893E588A9EFBC9BE585B6E4B8ADE4B880E4BA9BE4B893E5AEB6E585BCE4BBBBE585A8E59BBDE58D87E9998DE5B7A5E4BD9CE5B9B3E58FB0E6A087E58786E58C96E68A80E69CAFE5A794E59198E4BC9AE38081E4BD8FE5BBBAE983A8E696BDE5B7A5E5AE89E585A8E6A087E58786E58C96E5A794E59198E4BC9AE7AD89E4B893E4B89AE7BB84E7BB87E79A84E4B893E5AEB6E5A794E59198EFBC9BE794B1E8BF99E4BA9BE4B893E5AEB6E59BA2E9989FE7BB84E68890E79A84E9AB98E7A094E999A2EFBC8CE58DA0E68DAEE4BA86E8A18CE4B89AE68A80E69CAFE7A094E7A9B6E4B88EE58F91E5B195E79A84E588B6E9AB98E782B9EFBC8CE585B7E69C89E4BC98E8B68AE79A84E59BA2E9989FE4BC98E58ABFE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E9AB98E7A094E999A2E5B086E4BBA5E99B84E58E9AE79A84E4B893E4B89AE68A80E69CAFE8B584E6BA90E5928CE789B9E69C89E79A84E4B893E4B89AE7A094E58F91E883BDE58A9BEFBC8CE4B8BAE9AB98E7A9BAE4BD9CE4B89AE5B882E59CBAE68F90E4BE9BE585A8E696B9E4BD8DE79A84E4B880E7AB99E5BC8FE69C8DE58AA1E58F8AE585B3E994AEE68A80E69CAFE694AFE68C81E38082E9809AE8BF87E7A094E7A9B6E5BC80E58F91E696B0E4BAA7E59381E38081E696B0E68A80E69CAFE38081E696B0E79A84E6A380E6B58BE6898BE6AEB5EFBC8CE68F90E58D87E4B8ADE59BBDE588B6E980A0E79A84E699BAE883BDE58C96E7A88BE5BAA6E5928CE59BBDE99985E58C96E6B0B4E5B9B3EFBC9BE9809AE8BF87E4B893E4B89AE59FB9E8AEADEFBC8CE68F90E58D87E9AB98E5A484E4BD9CE4B89AE8AEBEE5A487E6938DE4BD9CE4BABAE59198E79A84E4B893E4B89AE7B4A0E8B4A8E58F8AE4B893E4B89AE68A80E883BDE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E5908EE9A1BEE697A0E5BFA7E4B8BBE8A681E79A84E69C8DE58AA1E7B1BBE588ABE58C85E68BACEFBC9AE697A0E5BFA7E59586E59F8EE38081E68A80E69CAFE694AFE68C81E38081E8B584E8B4A8E794B3E8AFB7E38081E6A380E6B58BE794B3E8AFB7E38081E59FB9E8AEADE794B3E8AFB7E38081E6A380E9AA8CE68AA5E5918AE4BA8CE7BBB4E7A081E9AA8CE8AF81E58F8AE697A0E5BFA7E696B0E997BBE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E697A0E5BFA7E59586E59F8EE68F90E4BE9BE4B8B0E5AF8CE4BC98E8B4A8E79A84E4BAA7E59381EFBC8CE59381E7B1BBE58C85E68BACEFBC9AE7AFAEE4BD93E992A2E7BB93E69E84E38081E68F90E58D87E69CBAE983A8E4BBB6E38081E9858DE794B5E7AEB1E983A8E4BBB6E38081E5AE89E585A8E99481E983A8E4BBB6E38081E794B5E7BC86E38081E992A2E4B89DE7BBB3E7AD89E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E68A80E69CAFE694AFE68C81E58C85E68BACE4B893E5AEB6E99D9EE6A087E696B9E6A188E8AEBEE8AEA1E38081E4B893E5AEB6E99D9EE6A087E696B9E6A188E8AEBAE8AF81E38081E4B893E5AEB6E4BA8BE69585E989B4E5AE9AE38081E4B893E5AEB6E4BAA7E59381E989B4E5AE9AEFBC8CE5B9B6E4B894E58FAFE4BBA5E9809AE8BF87E69585E99A9CE68E92E999A4E5B08FE79FADE78987E58F8AE69687E5AD97E8A7A3E8AFB4EFBC8CE8BF85E9809FE689BEE588B0E69585E99A9CE58E9FE59BA0EFBC8CE58F8AE697B6E68E92E999A4E69585E99A9CE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E8B584E8B4A8E7B1BBE588ABE58C85E68BACE5908AE7AFAEE7A79FE8B581E5AE89E8A385E8B584E8B4A8E38081E588B6E980A0E4BC81E4B89AE7949FE4BAA7E8B584E8B4A8E38082E4B8BAE58AA0E5BCBAE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE8A18CE4B89AE887AAE5BE8BE7AEA1E79086EFBC8CE79B91E79DA3E5908AE7AFAEE7A79FE8B581E5AE89E8A385E4BC81E4B89AE8A784E88C83E7BB8FE890A5EFBC8CE9AB98E7A094E999A2E789B9E588B6E5AE9AE4BA86E3808AE5908AE7AFAEE7A79FE8B581E5AE89E8A385E4BC81E4B89AE8B584E8B4A8E8AF84E5AEA1E7AEA1E79086E58A9EE6B395E3808BE58F8AE3808AE5908AE7AFAEE588B6E980A0E4BC81E4B89AE7949FE4BAA7E8B584E8B4A8E8AF84E5AEA1E7AEA1E79086E58A9EE6B395E3808BEFBC8CE5BC80E5B195E8AF84E5AEA1E5B7A5E4BD9CE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E6A380E6B58BE9A1B9E79BAEE58C85E68BACE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE38081E5AE89E585A8E99481E38081E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E38081E693A6E7AA97E69CBAE7AD89EFBC8CE5B9B6E6ADA3E59CA8E5BC80E5B195E5A194E5BC8FE8B5B7E9878DE69CBAE38081E696BDE5B7A5E58D87E9998DE69CBAE59CA8E58685E79A84E789B9E7A78DE8AEBEE5A487E6A380E9AA8CE6A380E6B58BE5B7A5E4BD9CEFBC8CE6A380E9AA8CE5908EE5B086E587BAE585B7E6ADA3E8A784E79A84E6A380E9AA8CE68AA5E5918AEFBC8CE9809AE8BF87E6898BE69CBAE689ABE68F8FE4BA8CE7BBB4E7A081E58FAFE4BBA5E58F8AE697B6E8BEA8E588ABE6A380E9AA8CE68AA5E5918AE79C9FE4BCAAE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E59FB9E8AEADE5B7A5E7A78DE58C85E68BACE5908AE7AFAEE6938DE4BD9CE5B7A5E38081E5908AE7AFAEE8A385E8B083E5B7A5E38081E794B5E5B7A5E38081E7848AE5B7A5E38081E992B3E5B7A5E38081E8BDA6E5B7A5E7AD89EFBC8CE4B8BAE585A8E8A18CE4B89AE59FB9E585BBE8BE93E98081E4B893E4B89AE696BDE5B7A5E58F8AE5AE89E8A385E68A80E69CAFE4BABAE6898DE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C65667422207374796C653D22746578742D696E64656E743A323870743B223E0D0A09E6ADA4E5A496EFBC8CE68891E4BBACE5B086E5AE9EE697B6E69BB4E696B0E697A0E5BFA7E696B0E997BBEFBC8CE8AEA9E5AEA2E688B7E58F8AE697B6E4BA86E8A7A3E8A18CE4B89AE58AA8E68081E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E5908EE9A1BEE697A0E5BFA7E99B86E9AB98E7A9BAE4BD9CE4B89AE4BAA7E59381E99BB6E594AEE38081E4B893E5AEB6E69C8DE58AA1E38081E6A380E6B58BE38081E59FB9E8AEADE4BA8EE4B880E4BD93EFBC8CE794B1E9AB98E7A094E999A2E8BF9BE8A18CE79B91E79DA3E7AEA1E79086EFBC8CE9809AE8BF87E7ACACE4B889E696B9E694AFE4BB98E5B9B3E58FB0E8BF9BE8A18CE4BAA4E69893E38082E5908EE9A1BEE697A0E5BFA7E5B086E4B8BAE5AEA2E688B7E68F90E4BE9BE696B9E4BEBFE5BFABE68DB7E79A84E7BD91E4B88AE4BAA4E69893E69C8DE58AA1EFBC8CE4B8BAE9AB98E7A9BAE4BD9CE4B89AE8A18CE4B89AE68F90E4BE9BE5AE89E585A8E58FAFE99DA0E79A84E4BAA7E59381EFBC8CE7BBB4E68AA4E8A18CE4B89AE68C81E7BBADE581A5E5BAB7E58F91E5B195E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3170743B223E0D0A09266E6273703B0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D2263656E74657222207374796C653D22746578742D616C69676E3A63656E7465723B223E0D0A093C623EE5908EE9A1BEE697A0E5BFA7E7AE80E4BB8B3C7370616E3E3C2F7370616E3E3C2F623E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E5908EE9A1BEE697A0E5BFA7E698AFE9AB98E7A9BAE69CBAE6A2B0E5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E999A2E69C89E99990E585ACE58FB8EFBC88E7AE80E7A7B0E9AB98E7A094E999A2EFBC89E69797E4B88BE585B3E4BA8EE9AB98E7A9BAE4BD9CE4B89AE4BAA7E59381E99480E594AEE58F8AE4B893E4B89AE68A80E69CAFE69C8DE58AA1E79A84E794B5E5AD90E59586E58AA1E5B9B3E58FB0E38082E5908EE9A1BEE697A0E5BFA7E887B4E58A9BE4BA8EE4B8BAE5AEA2E688B7E68F90E4BE9BE4BEBFE68DB7E79A84E68A80E69CAFE592A8E8AFA2E58F8AE59CA8E7BABFE4BAA4E69893E4BD93E9AA8CEFBC8CE9809AE8BF87E6898BE69CBAE5AEA2E688B7E7ABAFEFBC8CE68F90E4BE9BE58D93E8B68AE59381E8B4A8E79A84E59586E59381E5928CE69C8DE58AA1E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E9AB98E7A094E999A2E698AFE794B1E59BBDE5AEB6E5B7A5E59586E8A18CE694BFE680BBE5B180E6A0B8E58786E79A84E78BACE7AB8BE6B395E4BABAE58D95E4BD8DEFBC8CE698AFE4B893E4B89AE4BB8EE4BA8BE9AB98E7A9BAE696BDE5B7A5E69CBAE6A2B0E4B88EE5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E79A84E69CBAE69E84E38082E585B6E5898DE8BAABE698AFE6B19FE88B8FE9AB98E7A9BAE696BDE5B7A5E69CBAE6A2B0E5B7A5E7A88BE68A80E69CAFE7A094E7A9B6E999A2E69C89E99990E585ACE58FB8EFBC8CE68890E7AB8BE4BA8E3C7370616E3E323031333C2F7370616E3EE5B9B43C7370616E3E373C2F7370616E3EE69C88EFBC8CE585B7E69C89E59BBDE5AEB6E8B4A8E9878FE68A80E69CAFE79B91E79DA3E983A8E997A8E9A281E58F91E79A84E2809CE8AEA1E9878FE59088E6A0BCE7A1AEE8AEA4E8AF81E4B9A6E2809DE38082E9AB98E7A094E999A2E698AFE2809CE6B19FE88B8FE79C81E9AB98E7A9BAE69CBAE6A2B0E5908AE7AFAEE58D8FE4BC9AE2809DE589AFE4BC9AE995BFE58D95E4BD8DE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E9AB98E7A094E999A2E6B187E99B86E4BA86E59BBDE58685E5A496E4BC97E5A49AE79FA5E5908DE4B893E5AEB6E58F8AE6A380E6B58BE38081E59FB9E8AEADE8A18CE4B89AE8B584E6B7B1E4B893E5AEB6EFBC8CE69C89E79A84E58F82E4B88EE4BA86E4BD8FE5BBBAE983A8E3808AE585B3E4BA8EE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE696BDE5B7A5E5AE89E585A8E79B91E7AEA1E79A84E7A094E7A9B6E3808BE7AD89E9878DE5A4A7E8AFBEE9A298EFBC9BE69C89E79A84E4BD9CE4B8BAE8A18CE4B89AE68A80E69CAFE69D83E5A881EFBC8CE89197E69C89E59084E7B1BBE4B893E4B89AE89197E4BD9CEFBC9BE69C89E79A84E58F82E4B88EE8BF87E3808AE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE3808BE38081E3808AE693A6E7AA97E69CBAE3808BE7AD893C7370616E3E31303C2F7370616E3EE5A49AE9A1B9E59BBDE5AEB6E6A087E58786E5928CE8A18CE4B89AE6A087E58786E79A84E8B5B7E88D89E4B88EE7BC96E588B6E5B7A5E4BD9CEFBC9BE69C89E79A84E689BFE68B85E79D80E59BBDE5AEB6E2809CE58D81E4B880E4BA94E2809DE38081E2809CE58D81E4BA8CE4BA94E2809DE7A791E68A80E694AFE69291E8AEA1E58892E9878DE782B9E9A1B9E79BAEEFBC8CE88EB7E5BE97E8BF87E59BBDE5AEB6E5BBBAE8AEBEE7A791E68A80E2809CE58D8EE5A48FE5A596E2809DEFBC9BE69C89E79A84E68BA5E69C89E5A49AE9A1B9E69CACE4B893E4B89AE59BBDE5AEB6E58F91E6988EE4B893E588A9EFBC9BE585B6E4B8ADE4B880E4BA9BE4B893E5AEB6E585BCE4BBBBE585A8E59BBDE58D87E9998DE5B7A5E4BD9CE5B9B3E58FB0E6A087E58786E58C96E68A80E69CAFE5A794E59198E4BC9AE38081E4BD8FE5BBBAE983A8E696BDE5B7A5E5AE89E585A8E6A087E58786E58C96E5A794E59198E4BC9AE7AD89E4B893E4B89AE7BB84E7BB87E79A84E4B893E5AEB6E5A794E59198EFBC9BE794B1E8BF99E4BA9BE4B893E5AEB6E59BA2E9989FE7BB84E68890E79A84E9AB98E7A094E999A2EFBC8CE58DA0E68DAEE4BA86E8A18CE4B89AE68A80E69CAFE7A094E7A9B6E4B88EE58F91E5B195E79A84E588B6E9AB98E782B9EFBC8CE585B7E69C89E4BC98E8B68AE79A84E59BA2E9989FE4BC98E58ABFE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E9AB98E7A094E999A2E5B086E4BBA5E99B84E58E9AE79A84E4B893E4B89AE68A80E69CAFE8B584E6BA90E5928CE789B9E69C89E79A84E4B893E4B89AE7A094E58F91E883BDE58A9BEFBC8CE4B8BAE9AB98E7A9BAE4BD9CE4B89AE5B882E59CBAE68F90E4BE9BE585A8E696B9E4BD8DE79A84E4B880E7AB99E5BC8FE69C8DE58AA1E58F8AE585B3E994AEE68A80E69CAFE694AFE68C81E38082E9809AE8BF87E7A094E7A9B6E5BC80E58F91E696B0E4BAA7E59381E38081E696B0E68A80E69CAFE38081E696B0E79A84E6A380E6B58BE6898BE6AEB5EFBC8CE68F90E58D87E4B8ADE59BBDE588B6E980A0E79A84E699BAE883BDE58C96E7A88BE5BAA6E5928CE59BBDE99985E58C96E6B0B4E5B9B3EFBC9BE9809AE8BF87E4B893E4B89AE59FB9E8AEADEFBC8CE68F90E58D87E9AB98E5A484E4BD9CE4B89AE8AEBEE5A487E6938DE4BD9CE4BABAE59198E79A84E4B893E4B89AE7B4A0E8B4A8E58F8AE4B893E4B89AE68A80E883BDE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E5908EE9A1BEE697A0E5BFA7E4B8BBE8A681E79A84E69C8DE58AA1E7B1BBE588ABE58C85E68BACEFBC9AE697A0E5BFA7E59586E59F8EE38081E68A80E69CAFE694AFE68C81E38081E8B584E8B4A8E794B3E8AFB7E38081E6A380E6B58BE794B3E8AFB7E38081E59FB9E8AEADE794B3E8AFB7E38081E6A380E9AA8CE68AA5E5918AE4BA8CE7BBB4E7A081E9AA8CE8AF81E58F8AE697A0E5BFA7E696B0E997BBE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E697A0E5BFA7E59586E59F8EE68F90E4BE9BE4B8B0E5AF8CE4BC98E8B4A8E79A84E4BAA7E59381EFBC8CE59381E7B1BBE58C85E68BACEFBC9AE7AFAEE4BD93E992A2E7BB93E69E84E38081E68F90E58D87E69CBAE983A8E4BBB6E38081E9858DE794B5E7AEB1E983A8E4BBB6E38081E5AE89E585A8E99481E983A8E4BBB6E38081E794B5E7BC86E38081E992A2E4B89DE7BBB3E7AD89E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E68A80E69CAFE694AFE68C81E58C85E68BACE4B893E5AEB6E99D9EE6A087E696B9E6A188E8AEBEE8AEA1E38081E4B893E5AEB6E99D9EE6A087E696B9E6A188E8AEBAE8AF81E38081E4B893E5AEB6E4BA8BE69585E989B4E5AE9AE38081E4B893E5AEB6E4BAA7E59381E989B4E5AE9AEFBC8CE5B9B6E4B894E58FAFE4BBA5E9809AE8BF87E69585E99A9CE68E92E999A4E5B08FE79FADE78987E58F8AE69687E5AD97E8A7A3E8AFB4EFBC8CE8BF85E9809FE689BEE588B0E69585E99A9CE58E9FE59BA0EFBC8CE58F8AE697B6E68E92E999A4E69585E99A9CE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3070743B223E0D0A09E8B584E8B4A8E7B1BBE588ABE58C85E68BACE5908AE7AFAEE7A79FE8B581E5AE89E8A385E8B584E8B4A8E38081E588B6E980A0E4BC81E4B89AE7949FE4BAA7E8B584E8B4A8E38082E4B8BAE58AA0E5BCBAE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE8A18CE4B89AE887AAE5BE8BE7AEA1E79086EFBC8CE79B91E79DA3E5908AE7AFAEE7A79FE8B581E5AE89E8A385E4BC81E4B89AE8A784E88C83E7BB8FE890A5EFBC8CE9AB98E7A094E999A2E789B9E588B6E5AE9AE4BA86E3808AE5908AE7AFAEE7A79FE8B581E5AE89E8A385E4BC81E4B89AE8B584E8B4A8E8AF84E5AEA1E7AEA1E79086E58A9EE6B395E3808BE58F8AE3808AE5908AE7AFAEE588B6E980A0E4BC81E4B89AE7949FE4BAA7E8B584E8B4A8E8AF84E5AEA1E7AEA1E79086E58A9EE6B395E3808BEFBC8CE5BC80E5B195E8AF84E5AEA1E5B7A5E4BD9CE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E6A380E6B58BE9A1B9E79BAEE58C85E68BACE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE38081E5AE89E585A8E99481E38081E99984E79D80E5BC8FE58D87E9998DE8849AE6898BE69EB6E38081E693A6E7AA97E69CBAE7AD89EFBC8CE5B9B6E6ADA3E59CA8E5BC80E5B195E5A194E5BC8FE8B5B7E9878DE69CBAE38081E696BDE5B7A5E58D87E9998DE69CBAE59CA8E58685E79A84E789B9E7A78DE8AEBEE5A487E6A380E9AA8CE6A380E6B58BE5B7A5E4BD9CEFBC8CE6A380E9AA8CE5908EE5B086E587BAE585B7E6ADA3E8A784E79A84E6A380E9AA8CE68AA5E5918AEFBC8CE9809AE8BF87E6898BE69CBAE689ABE68F8FE4BA8CE7BBB4E7A081E58FAFE4BBA5E58F8AE697B6E8BEA8E588ABE6A380E9AA8CE68AA5E5918AE79C9FE4BCAAE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E59FB9E8AEADE5B7A5E7A78DE58C85E68BACE5908AE7AFAEE6938DE4BD9CE5B7A5E38081E5908AE7AFAEE8A385E8B083E5B7A5E38081E794B5E5B7A5E38081E7848AE5B7A5E38081E992B3E5B7A5E38081E8BDA6E5B7A5E7AD89EFBC8CE4B8BAE585A8E8A18CE4B89AE59FB9E585BBE8BE93E98081E4B893E4B89AE696BDE5B7A5E58F8AE5AE89E8A385E68A80E69CAFE4BABAE6898DE380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C2220616C69676E3D226C65667422207374796C653D22746578742D696E64656E743A323870743B223E0D0A09E6ADA4E5A496EFBC8CE68891E4BBACE5B086E5AE9EE697B6E69BB4E696B0E697A0E5BFA7E696B0E997BBEFBC8CE8AEA9E5AEA2E688B7E58F8AE697B6E4BA86E8A7A3E8A18CE4B89AE58AA8E68081E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32382E3070743B223E0D0A09E5908EE9A1BEE697A0E5BFA7E99B86E9AB98E7A9BAE4BD9CE4B89AE4BAA7E59381E99BB6E594AEE38081E4B893E5AEB6E69C8DE58AA1E38081E6A380E6B58BE38081E59FB9E8AEADE4BA8EE4B880E4BD93EFBC8CE794B1E9AB98E7A094E999A2E8BF9BE8A18CE79B91E79DA3E7AEA1E79086EFBC8CE9809AE8BF87E7ACACE4B889E696B9E694AFE4BB98E5B9B3E58FB0E8BF9BE8A18CE4BAA4E69893E38082E5908EE9A1BEE697A0E5BFA7E5B086E4B8BAE5AEA2E688B7E68F90E4BE9BE696B9E4BEBFE5BFABE68DB7E79A84E7BD91E4B88AE4BAA4E69893E69C8DE58AA1EFBC8CE4B8BAE9AB98E7A9BAE4BD9CE4B89AE8A18CE4B89AE68F90E4BE9BE5AE89E585A8E58FAFE99DA0E79A84E4BAA7E59381EFBC8CE7BBB4E68AA4E8A18CE4B89AE68C81E7BBADE581A5E5BAB7E58F91E5B195E380823C7370616E3E3C2F7370616E3E200D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3170743B223E0D0A09266E6273703B0D0A3C2F703E0D0A3C703E0D0A093C6272202F3E0D0A3C2F703E0D0A3C703E0D0A093C6272202F3E0D0A3C2F703E0D0A3C7020636C6173733D224D736F4E6F726D616C22207374796C653D22746578742D696E64656E743A32342E3170743B223E0D0A093C6272202F3E0D0A3C2F703E0D0A3C703E0D0A093C6272202F3E0D0A3C2F703E0D0A3C703E0D0A093C6272202F3E0D0A3C2F703E, null, '00003');
INSERT INTO `news` VALUES ('d36b35a3-5b17-49ae-807a-e9cb1fc557ff', '高研院开展物联网技术研发与应用', '', '\0', null, '2015-04-20 00:00:00', '物联网技术研发与应用', 0x3C70207374796C653D22746578742D616C69676E3A6C6566743B746578742D696E64656E743A323170743B2220636C6173733D224D736F4E6F726D616C223E0D0A09E789A9E88194E7BD91E68C87E9809AE8BF87E4BFA1E681AFE4BCA0E6849FE8AEBEE5A487EFBC8CE68C89E785A7E7BAA6E5AE9AE79A84E58D8FE8AEAEEFBC8CE68A8AE4BBBBE4BD95E789A9E59381E4B88EE4BA92E88194E7BD91E8BF9EE68EA5E8B5B7E69DA5EFBC8CE8BF9BE8A18CE4BFA1E681AFE4BAA4E68DA2E5928CE9809AE4BFA1EFBC8CE4BBA5E5AE9EE78EB0E699BAE883BDE58C96E8AF86E588ABE38081E5AE9AE4BD8DE38081E8B79FE8B8AAE38081E79B91E68EA7E5928CE7AEA1E79086E79A84E4B880E7A78DE58588E8BF9BE79A84E7BD91E7BB9CE68A80E69CAFE380823C6272202F3E0D0AE9AB98E5A484E4BD9CE4B89AE5908AE7AFAEE698AFE5BA94E794A8E69C80E4B8BAE5B9BFE6B39BE79A84E9AB98E7A9BAE69CBAE6A2B0EFBC8CE79BAEE5898DE585A8E59BBDE4BDBFE794A8E9878FE59CA8313530E4B887E58FB0E4BBA5E4B88AE38082E4BD9CE4B8BAE794A8E992A2E4B89DE7BBB3E682ACE5908AE79A84E8BDBDE4BABAE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0EFBC8CE585B6E4BDBFE794A8E79A84E58DB1E999A9E680A7E99D9EE5B8B8E5A4A7E380823C6272202F3E0D0AE794B1E4BA8EE8AEBEE5A487E99A90E682A3E68896E69585E99A9CE4BBA5E58F8AE4BABAE59198E6938DE4BD9CE5A4B1E8AFAFE38081E588A4E696ADE99499E8AFAFE38081E8BF9DE7ABA0E6938DE4BD9CE7AD89E58E9FE59BA0EFBC8CE68891E59BBDE6AF8FE5B9B4E983BDE4BC9AE58F91E7949FE695B0E58D81E8B5B7E5908AE7AFAEE59DA0E890BDE79A84E5AE89E585A8E4BA8BE69585EFBC8CE6ADBBE4BAA1E4B88AE799BEE4BABAE380823C6272202F3E0D0A266E6273703B20266E6273703B20E4BD9CE4B8BAE8BDBDE4BABAE9AB98E7A9BAE4BD9CE4B89AE69CBAE6A2B0EFBC8CE5908AE7AFAEE79A84E5AE89E585A8E680A7E5928CE58FAFE99DA0E680A7E698AFE887B3E585B3E9878DE8A681E38082E4B8BAE6ADA4EFBC8CE68891E999A2E6ADA3E59CA8E7A094E588B6E5BC80E58F91E587BAE4B880E7A78DE8BF90E794A8E789A9E88194E7BD91E68A80E69CAFE5B086E8BF9CE7A88BE887AAE58AA8E79B91E68EA7E68A80E69CAFE5BA94E794A8E59CA8E5908AE7AFAEE4B88AE79A84E7B3BBE7BB9FE38082E4BDBFE585B6E4B88DE4BB85E585B7E5A487E5AFB9E5908AE7AFAEE79A84E8BF90E8A18CE5AE9EE697B6E79B91E6B58BE4B88EE8AEB0E5BD95EFBC8CE5AFB9E8AEBEE5A487E8BF9BE8A18CE69585E99A9CE9A284E588A4E4B88EE68AA5E8ADA6EFBC8CE58F8AE697B6E58786E7A1AEE58F91E78EB0E69585E99A9CE99A90E682A3EFBC8CE8808CE4B894E585B7E5A487E699BAE883BDE58C96E5B9B2E9A284E5B9B6E4B894E99990E588B6E8BF9DE7ABA0E68896E8AFAFE6938DE4BD9CE79A84E58A9FE883BDEFBC8CE883BDE5A49FE69C89E69588E981BFE5858DE59BA0E4BABAE4B8BAE59BA0E7B4A0E68896E8AEBEE5A487E99A90E682A3E5BC95E58F91E79A84E4BA8BE69585E380820D0A3C2F703E0D0A3C70207374796C653D22746578742D616C69676E3A6C6566743B746578742D696E64656E743A323170743B2220636C6173733D224D736F4E6F726D616C223E0D0A093C6272202F3E0D0A3C2F703E, '179', '00001');

-- ----------------------------
-- Table structure for newstype
-- ----------------------------
DROP TABLE IF EXISTS `newstype`;
CREATE TABLE `newstype` (
  `typeid` varchar(36) COLLATE utf8_bin NOT NULL,
  `typename` varchar(50) COLLATE utf8_bin NOT NULL,
  `typelogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `sort` int(11) NOT NULL,
  `Isshow` bit(1) NOT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of newstype
-- ----------------------------
INSERT INTO `newstype` VALUES ('00001', '新闻资讯', null, '0', '', '1');
INSERT INTO `newstype` VALUES ('00002', '租赁信息', null, '0', '', '2');
INSERT INTO `newstype` VALUES ('00003', '公司简介', null, '0', '', '3');
INSERT INTO `newstype` VALUES ('00004', '企业介绍', null, '0', '', '4');
INSERT INTO `newstype` VALUES ('00005', '荣誉资质', null, '0', '', '5');

-- ----------------------------
-- Table structure for order
-- ----------------------------
DROP TABLE IF EXISTS `order`;
CREATE TABLE `order` (
  `orderid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '订单id',
  `userid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '用户编号',
  `addrid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '收货地址编号',
  `ordernumber` varchar(50) COLLATE utf8_bin NOT NULL COMMENT '订单号',
  `ordertype` varchar(50) COLLATE utf8_bin NOT NULL COMMENT '订单类型 1商品订单2培训订单3检测申请订单4资质申请订单5专家非标准方案设计申请6专家非标准方案认证申请7产品鉴定申请8事故鉴定申请',
  `orderstruts` varchar(10) COLLATE utf8_bin NOT NULL COMMENT '订单状态1.待付款2.待发货3.待收货4.待评价 0.取消订单9完成订单',
  `ordercountprice` double(18,2) NOT NULL COMMENT '订单总价格',
  `orderall` varchar(500) COLLATE utf8_bin DEFAULT NULL COMMENT '订单全部商品',
  `orderuserdiscount` double(18,2) NOT NULL COMMENT '下单时会员使用的会员等级折扣',
  `orderdate` datetime NOT NULL COMMENT '下单时间',
  `expresscompanyid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `expresscompanyname` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单物流公司名称',
  `ordersendgoodsexpressnumber` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单物流号',
  `orderrejectgoodsexpresscompanyid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `orderrejectgoodsexpresscompanyname` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单退货物流公司名称',
  `orderrejectgoodsexpressnumber` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单退货物流号',
  `orderrejectgoodsremark` varchar(500) COLLATE utf8_bin DEFAULT NULL COMMENT '订单退货备注',
  `orderistytuikuan` int(2) DEFAULT NULL COMMENT '是否同意退款   1:同意退款  2：拒绝退款  0:待处理',
  `ordertuikuanliyou` varchar(1000) COLLATE utf8_bin DEFAULT NULL COMMENT '是否同意退款理由',
  `usepoints` double(18,2) NOT NULL DEFAULT '0.00',
  `yunfei` double(18,2) DEFAULT '0.00',
  PRIMARY KEY (`orderid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of order
-- ----------------------------
INSERT INTO `order` VALUES ('02111c0a-b64d-4015-8356-85a816bd4796', '6ad19cc5-14a0-4743-ab88-4b3c10455703', '614ed591-ae1d-446d-8ad7-8893a77cb639', '151203114437176', '1', '1', '118.00', null, '0.98', '2015-12-03 11:44:37', null, null, null, null, null, null, null, null, null, '0.00', '20.00');
INSERT INTO `order` VALUES ('1597b817-b0d5-4979-a616-b8a14090e899', 'ead5c475-6fbc-44f1-b4e7-ef8abf1aa3fe', 'e5c72c98-fbfd-4414-8990-e8ee6818af7c', '160515232909296', '1', '1', '16000.00', null, '1.00', '2016-05-15 23:29:09', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('2a39a803-6ab1-44d8-b7e6-91b3412a22fd', '6ad19cc5-14a0-4743-ab88-4b3c10455703', '614ed591-ae1d-446d-8ad7-8893a77cb639', '151206143718626', '1', '1', '245.00', null, '0.98', '2015-12-06 14:37:18', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('3f8b6007-e683-4fd4-9265-b23f79cf2eb6', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '151201234822864', '1', '6', '0.10', null, '0.10', '2015-12-01 23:48:22', 'guotongkuaidi', '国通快递', '34324323244', 'guotongkuaidi', null, '花费巨额家', '笑呵呵susususuu', '1', '', '0.00', '0.00');
INSERT INTO `order` VALUES ('43076e71-344d-4023-8ed9-44025a18e1fa', '6ad19cc5-14a0-4743-ab88-4b3c10455703', '614ed591-ae1d-446d-8ad7-8893a77cb639', '15120623464130', '1', '6', '69.00', null, '0.98', '2015-12-06 23:46:41', null, null, null, 'ems', null, '12312312321312312', '312312', '1', '', '0.00', '20.00');
INSERT INTO `order` VALUES ('4907344c-bd69-4dfb-99bb-8573d40b8097', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '15121809520787', '1', '1', '118.00', null, '0.98', '2015-12-18 09:52:07', null, null, null, null, null, null, null, null, null, '0.00', '20.00');
INSERT INTO `order` VALUES ('4a2f3224-f4c1-410d-9168-59114fe7bd63', '9384d577-dbdb-4d20-90ce-3fdc2a889191', '', '160712141051473', '1', '1', '24000.00', null, '1.00', '2016-07-12 14:10:51', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('4e4cb0d5-9cb2-4cca-b723-781b121cc067', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '151219092505193', '2', '1', '1881.00', null, '1881.00', '2015-12-19 09:25:05', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('5427e7bd-85fc-4bbe-b151-ec02b8aac111', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '43182252-5346-4eeb-b65f-390473682b52', '151229141818983', '1', '3', '0.10', null, '1.00', '2015-12-29 14:18:18', 'yunda', '韵达快运', '25330055866', null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('5632fe90-7f1f-4bed-9838-a78f183f9992', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '151230142708384', '2', '1', '188.00', null, '188.00', '2015-12-30 14:27:08', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('5d414ef1-87dd-42aa-a11e-6e94516843e7', '577c8982-c23b-405a-b204-ee12bdde7c95', '9896a57e-965c-4a74-8f22-aad276f2b8f2', '160305190528209', '1', '1', '7840.00', null, '0.98', '2016-03-05 19:05:28', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('61b5d5bc-6d89-4a32-a421-88f99a180376', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '151230150229120', '2', '1', '188.00', null, '188.00', '2015-12-30 15:02:29', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('6946481c-61bd-4c29-a16c-6c3406d4af01', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '160120085423252', '1', '1', '0.10', null, '1.00', '2016-01-20 08:54:23', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('75a8c966-318b-49b3-af84-f2c97d787c7b', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '151129154547156', '1', '6', '0.01', null, '0.90', '2015-11-29 15:45:47', 'dsukuaidi', 'D速快递', '10000000', 'dsukuaidi', null, '151129154547156', '', '1', '', '0.00', '20.00');
INSERT INTO `order` VALUES ('87237a2a-d590-4e54-a928-857e0fd12ec9', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '151230144524133', '2', '1', '188.00', null, '188.00', '2015-12-30 14:45:24', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('900f4828-c9ad-462b-baa0-336befd7e583', '577c8982-c23b-405a-b204-ee12bdde7c95', '9896a57e-965c-4a74-8f22-aad276f2b8f2', '160721162501423', '1', '1', '7840.00', null, '0.98', '2016-07-21 16:25:01', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('9a39b825-f8a8-4dac-ab8e-3ebb025f9791', '577c8982-c23b-405a-b204-ee12bdde7c95', '9896a57e-965c-4a74-8f22-aad276f2b8f2', '151201232518222', '1', '6', '110.00', null, '0.90', '2015-12-01 23:25:18', null, null, null, null, null, null, null, null, null, '0.00', '20.00');
INSERT INTO `order` VALUES ('a0b06fa5-3c48-4f3a-be38-ae1ca5512f14', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '151202225014431', '1', '8', '0.10', null, '0.10', '2015-12-02 22:50:14', 'guotongkuaidi', '国通快递', '4343434', 'guotongkuaidi', null, 'ttt', 'tttg', null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('a8cdeb0b-bce4-4f12-b0c7-c2d1b610fc0c', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '15123014592819', '2', '1', '1881.00', null, '1881.00', '2015-12-30 14:59:28', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('c7356b70-d5c2-4373-b101-f7680e562458', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '151230145654745', '2', '1', '1881.00', null, '1881.00', '2015-12-30 14:56:54', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('c7c9829e-a286-49e2-a3e5-454a744be50d', 'ead5c475-6fbc-44f1-b4e7-ef8abf1aa3fe', 'e5c72c98-fbfd-4414-8990-e8ee6818af7c', '160515232813870', '1', '1', '8000.00', null, '1.00', '2016-05-15 23:28:13', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('ce824c67-5b04-48f1-8f4a-34fa44b4b679', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '151206234304754', '1', '6', '69.00', null, '0.98', '2015-12-06 23:43:04', 'guotongkuaidi', '国通快递', '43434324', 'ganzhongnengda', null, '2252555', 'v话费广告费反反复复', '1', '', '0.00', '20.00');
INSERT INTO `order` VALUES ('cfdfcd58-2580-42da-9d82-5920fd7f03eb', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '15120700003010', '1', '1', '68.00', null, '0.98', '2015-12-07 00:00:30', null, null, null, null, null, null, null, null, null, '1.00', '20.00');
INSERT INTO `order` VALUES ('d90323e4-ad95-4bed-a550-93ff25daeb1c', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '151222160411819', '1', '1', '69.00', null, '0.98', '2015-12-22 16:04:11', null, null, null, null, null, null, null, null, null, '0.00', '20.00');
INSERT INTO `order` VALUES ('dc61ed5a-1821-41b0-9f7f-2c10f885217e', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '15120719250918', '1', '6', '69.00', null, '0.98', '2015-12-07 19:25:09', null, null, null, null, null, null, '小姐小鸡小鸡大家', '1', '', '0.00', '20.00');
INSERT INTO `order` VALUES ('dd12fb25-0c20-4285-9962-522d244ed3d7', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '151230135328222', '2', '1', '1881.00', null, '1881.00', '2015-12-30 13:53:28', null, null, null, null, null, null, null, null, null, '0.00', null);
INSERT INTO `order` VALUES ('dfb2f6a3-7959-4154-a424-24c34c5521f2', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '160120085823877', '1', '1', '0.10', null, '1.00', '2016-01-20 08:58:23', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('ecec7155-5db8-4150-a72e-b1f866e1dc82', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'ab92627a-022f-48d0-88ed-150dcb846328', '151214172810805', '1', '1', '147.00', null, '0.98', '2015-12-14 17:28:10', null, null, null, null, null, null, null, null, null, '0.00', '0.00');
INSERT INTO `order` VALUES ('f18e7cbb-0015-475e-9984-33b879766f0f', '1bbd62df-d47a-4d65-99ed-41f16181684a', '3c949b57-1b83-40a9-a6b7-5d96f5c72ad8', '151201204325975', '1', '1', '70.00', null, '1.00', '2015-12-01 20:43:25', null, null, null, null, null, null, null, null, null, '0.00', '20.00');

-- ----------------------------
-- Table structure for ordergoods
-- ----------------------------
DROP TABLE IF EXISTS `ordergoods`;
CREATE TABLE `ordergoods` (
  `guid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '订单商品主键',
  `orderid` varchar(36) COLLATE utf8_bin NOT NULL,
  `ordergoodsid` varchar(36) COLLATE utf8_bin NOT NULL COMMENT '订单商品id',
  `ordergoodslogo` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单商品logo',
  `ordergoodsname` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单商品名称',
  `ordergoodsprice` double(18,2) NOT NULL COMMENT '订单商品价格',
  `ordergoodsdiscountprice` double(18,2) NOT NULL COMMENT '订单商品折扣价格',
  `ordergoodssize` int(11) NOT NULL COMMENT '订单商品数量',
  `ordergoodscountprice` double(18,2) NOT NULL COMMENT '订单商品总价格',
  PRIMARY KEY (`guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of ordergoods
-- ----------------------------
INSERT INTO `ordergoods` VALUES ('04c2e5c2-adb4-4836-978b-28d02767f469', '6417817b-0aef-4f5a-8896-ee25b9202cf3', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '45.00', '1', '45.00');
INSERT INTO `ordergoods` VALUES ('0587a402-8c8e-40e5-9db3-4a7c246ddacb', '900f4828-c9ad-462b-baa0-336befd7e583', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '8000.00', '7840.00', '1', '7840.00');
INSERT INTO `ordergoods` VALUES ('08665526-ffca-4d60-b3d0-3f995f55940d', '324b2678-b692-4147-9825-7e1529300b43', 'ff351434-2457-4e41-84a8-41285ec248cb', '/fileupload/goods/Original/b031705b19794e6b9a13a1f665459dbe.jpg', '方孔衬圈', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('17fb7fb1-0a39-4102-8a9b-942f5bb82c1c', '18099b01-317c-4b2a-b268-da709efe6f3c', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('1d21ccc2-c6ca-4e48-b6cd-020bd160474e', 'ecec7155-5db8-4150-a72e-b1f866e1dc82', '9ca5900a-57ab-4bd1-8ffc-dc580b8d9063', '/fileupload/goods/Original/9eb1ee6cd6d14f6c8c9c727345843fc7.png', '航空插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('1db3cf96-5ed8-47f5-8bd1-72d1f3c6d8f8', '1597b817-b0d5-4979-a616-b8a14090e899', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '8000.00', '8000.00', '1', '8000.00');
INSERT INTO `ordergoods` VALUES ('20c128ff-f617-442a-927d-363c0e16f510', '886364e9-e8bf-4d6a-9af1-c6539cdcbe92', 'fefcd0fa-fbc2-487b-96d1-d68eaaa9a961', '/fileupload/goods/Original/0225366db44f4082b98439fcd904ea3f.jpg', '后支架', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('2aa76144-904e-47cd-a53d-4393d4a0f0d2', '75a8c966-318b-49b3-af84-f2c97d787c7b', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '80提升机大齿轮', '1.00', '0.90', '1', '0.90');
INSERT INTO `ordergoods` VALUES ('2b5aeb8f-4100-42a3-86e3-a04d77e44e45', 'c7c9829e-a286-49e2-a3e5-454a744be50d', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '8000.00', '8000.00', '1', '8000.00');
INSERT INTO `ordergoods` VALUES ('34f57519-16dc-4b83-9cd6-a4f028b4391f', 'e2a75811-5bdb-4433-82c0-27529b8edc72', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '80提升机大齿轮', '1.00', '0.90', '1', '0.90');
INSERT INTO `ordergoods` VALUES ('36be615f-e0e8-4126-bb45-c1219c595fae', 'f18e7cbb-0015-475e-9984-33b879766f0f', 'ec66d531-8dc6-474d-9a2a-7b9ab2ab194b', '/fileupload/goods/Original/3297ce20f5d34b2fa683229ecba88882.png', '摆臂', '50.00', '50.00', '1', '50.00');
INSERT INTO `ordergoods` VALUES ('36ef8cec-b3d4-4316-835e-1ca2b26db2b7', '4d845639-718a-4dd0-a7ac-f89084a07072', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('3cd8a800-0639-4352-a408-0ef7e7d2bc67', '0a172899-74dd-435b-afc2-aa10f83ba9e5', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('43ba4c5f-25a8-4193-a4be-614a35793084', '02111c0a-b64d-4015-8356-85a816bd4796', 'ac0fe116-dde9-414a-a924-4bed0c5ace67', '/fileupload/goods/Original/5d5a0173738e43db8260994577b5eb23.jpg', '风叶', '50.00', '49.00', '2', '98.00');
INSERT INTO `ordergoods` VALUES ('49b21f6f-3a9f-4465-91ec-d191535abf17', '6946481c-61bd-4c29-a16c-6c3406d4af01', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '800提升机大齿轮', '0.10', '0.10', '1', '0.10');
INSERT INTO `ordergoods` VALUES ('4c60271f-dc7b-4cef-bb50-ae56d76e2a36', 'c0c265b5-d539-488e-823a-287e2f3da2a5', 'fefcd0fa-fbc2-487b-96d1-d68eaaa9a961', '/fileupload/goods/Original/0225366db44f4082b98439fcd904ea3f.jpg', '后支架', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('4df29ad0-2d19-474d-93a0-dcf3ec524f8a', '275c62ea-21a8-4e25-bf15-71e5ea81a9a8', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('53d6f68e-007d-41d4-9d8b-ddfd537efd21', '86f4d6d4-c633-4e92-b173-b5e9acb95489', 'fefcd0fa-fbc2-487b-96d1-d68eaaa9a961', '/fileupload/goods/Original/0225366db44f4082b98439fcd904ea3f.jpg', '后支架', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('5a62c2c0-314e-4395-8833-36645db42f6d', '2a39a803-6ab1-44d8-b7e6-91b3412a22fd', '1e9a5f24-078c-4e22-937f-b936a70cbf08', '/fileupload/goods/Original/b0c1f778b4bd44ada970825fbcf28a6a.jpg', '压轮组件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('60c58fb3-1bd1-47e6-b134-f8ff708296d7', '4907344c-bd69-4dfb-99bb-8573d40b8097', 'c3ea23da-d482-4e05-b50a-c6119b2c2f68', '/fileupload/goods/Original/0bb615b4a4b04c9ba0f14dea7251234e.png', '五芯工业插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('687df3bd-f304-4e87-842e-b9fcedf32cc2', '10173aa1-b72c-4503-9743-9e274d050cda', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '45.00', '1', '45.00');
INSERT INTO `ordergoods` VALUES ('6eecc36f-8f29-4dde-855c-9cda850abb83', '4240ecc2-3999-4d5b-a8ed-9cc05a363333', 'fefcd0fa-fbc2-487b-96d1-d68eaaa9a961', '/fileupload/goods/Original/0225366db44f4082b98439fcd904ea3f.jpg', '后支架', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('70bb9654-4718-41b9-80a6-0552fed38be7', 'ae617c37-8d3a-47c8-8868-5f3773c4b7cf', 'ec66d531-8dc6-474d-9a2a-7b9ab2ab194b', '/fileupload/goods/Original/3297ce20f5d34b2fa683229ecba88882.png', '摆臂', '50.00', '45.00', '1', '45.00');
INSERT INTO `ordergoods` VALUES ('71f16d6a-3e66-45f9-b067-9c8c3061268d', '9a39b825-f8a8-4dac-ab8e-3ebb025f9791', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '45.00', '2', '90.00');
INSERT INTO `ordergoods` VALUES ('77e79258-9254-45a2-9096-53499a351ac8', '61630779-94b1-4eb0-a534-18f23a5facf9', '4793df4a-f08c-4c78-bf52-9c4fa6706ef2', '/fileupload/goods/Original/bdd9c2ed2eef4f66917b32d32cbbfc4e.jpg', '滚子', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('823b3459-1712-4a48-9320-29d5ee3fc7ed', 'e688a690-e62b-4709-9570-60cfb15f452d', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('87f799e5-70c2-491d-a132-6167dac48ba9', '7751aafc-0dad-4bfe-812d-37b78a1b53f7', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '50.00', '45.00', '1', '45.00');
INSERT INTO `ordergoods` VALUES ('8941f566-2bc7-4566-b2ba-bb400a79d3b4', '4a2f3224-f4c1-410d-9168-59114fe7bd63', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '8000.00', '8000.00', '3', '24000.00');
INSERT INTO `ordergoods` VALUES ('8f5749c4-89cf-4575-bf55-843f5d3f768a', 'dc61ed5a-1821-41b0-9f7f-2c10f885217e', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('a38accf9-ccfd-4cbe-94b8-f1d97fc2962b', 'c63aa65d-3a4e-4c56-b8a5-f69c8bc49896', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('aadaa321-5929-4dd2-8250-881ae0ec240e', '3f8b6007-e683-4fd4-9265-b23f79cf2eb6', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '80提升机大齿轮', '1.00', '0.10', '1', '0.10');
INSERT INTO `ordergoods` VALUES ('ac980b55-2efe-4b61-8465-ecb606f8bf31', 'd1e5f4ed-520b-4429-a053-72ba0ab2ec9f', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('ad878267-2e06-4a4b-8a26-0ed5ec9fcfd5', '5427e7bd-85fc-4bbe-b151-ec02b8aac111', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '800提升机大齿轮', '0.10', '0.10', '1', '0.10');
INSERT INTO `ordergoods` VALUES ('ae9a41a3-ae2d-4eee-9059-638bf4076f67', '2d766b50-e36a-4232-acb4-7d71b34433dc', 'ec66d531-8dc6-474d-9a2a-7b9ab2ab194b', '/fileupload/goods/Original/3297ce20f5d34b2fa683229ecba88882.png', '摆臂', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('b438387c-f285-4c2b-adb8-ae84c1f3d738', '0caf0f60-7fae-40b6-a723-e9fc8b71d9f5', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '5.00', '1', '5.00');
INSERT INTO `ordergoods` VALUES ('b818a17e-87a0-42cb-b898-948e6e5507df', 'd90323e4-ad95-4bed-a550-93ff25daeb1c', 'c3ea23da-d482-4e05-b50a-c6119b2c2f68', '/fileupload/goods/Original/0bb615b4a4b04c9ba0f14dea7251234e.png', '五芯工业插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('b9d5573b-aa70-457a-b3c2-229ebd315168', 'b554b60e-69fd-44b7-b09e-66a0d70111c8', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('c16b8155-5bd8-46b2-a577-a7d4bdf10b7a', '38263ad7-fcf6-4aa4-9fc3-cb110dd792d2', '9ca5900a-57ab-4bd1-8ffc-dc580b8d9063', '/fileupload/goods/Original/9eb1ee6cd6d14f6c8c9c727345843fc7.png', '航空插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('c88e5524-a8da-4566-9557-25e927b162fa', '5d414ef1-87dd-42aa-a11e-6e94516843e7', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '8000.00', '7840.00', '1', '7840.00');
INSERT INTO `ordergoods` VALUES ('cc1c5928-c9ab-490a-964c-cf41d8b106af', '2a39a803-6ab1-44d8-b7e6-91b3412a22fd', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '4', '196.00');
INSERT INTO `ordergoods` VALUES ('cd880323-5484-4068-b72b-840f45e5b8a8', 'dfb2f6a3-7959-4154-a424-24c34c5521f2', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '800提升机大齿轮', '0.10', '0.10', '1', '0.10');
INSERT INTO `ordergoods` VALUES ('ce0a91ce-cf45-4db2-a9b3-5138ceb872f0', '1597b817-b0d5-4979-a616-b8a14090e899', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '8000.00', '8000.00', '1', '8000.00');
INSERT INTO `ordergoods` VALUES ('cf729403-eeb4-4a89-be2f-c6e2f9c12faa', 'de510093-cfe5-498b-a51f-6cafdad9df66', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '45.00', '1', '45.00');
INSERT INTO `ordergoods` VALUES ('d2950352-7a9a-4563-a3aa-df0ccce9766b', 'caed6930-b189-4f30-9f39-93aedbdbb141', 'c3ea23da-d482-4e05-b50a-c6119b2c2f68', '/fileupload/goods/Original/0bb615b4a4b04c9ba0f14dea7251234e.png', '五芯工业插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('d58f4ec5-89e1-44b6-b09f-57f1fb329c50', '43076e71-344d-4023-8ed9-44025a18e1fa', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('da22c27f-8ed8-4418-985f-dbb38350caca', '5a8d15ad-316b-4f0a-8547-8904f94f6c70', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '5', '245.00');
INSERT INTO `ordergoods` VALUES ('dc5de04f-865c-430e-b008-ee7d58b406d5', 'e705a049-40bb-4e81-9409-ab5d91676ed9', 'e802a249-e41c-4392-8c79-a7fb43d427ff', '/fileupload/goods/Original/900fcf53f9c94035bd914fcede7f4c33.png', '十芯插件', '50.00', '45.00', '1', '45.00');
INSERT INTO `ordergoods` VALUES ('e09c0250-aca2-47a0-8ba6-4bae2ec0be7c', '4907344c-bd69-4dfb-99bb-8573d40b8097', 'ec66d531-8dc6-474d-9a2a-7b9ab2ab194b', '/fileupload/goods/Original/3297ce20f5d34b2fa683229ecba88882.png', '摆臂', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('e12e3e6b-302d-48d1-a654-a29490d5728f', 'a0b06fa5-3c48-4f3a-be38-ae1ca5512f14', '0b59aee8-f586-456b-a03f-ee23483e6cdc', '/fileupload/goods/Original/47929dded2d94d47af675783be9dee25.jpg', '80提升机大齿轮', '1.00', '0.10', '1', '0.10');
INSERT INTO `ordergoods` VALUES ('e19706d5-0ffe-4442-920b-fedb9f4c969d', 'ecec7155-5db8-4150-a72e-b1f866e1dc82', 'ec66d531-8dc6-474d-9a2a-7b9ab2ab194b', '/fileupload/goods/Original/3297ce20f5d34b2fa683229ecba88882.png', '摆臂', '50.00', '49.00', '2', '98.00');
INSERT INTO `ordergoods` VALUES ('e464f703-274a-4608-9e6e-14c61602818f', '38af7b04-e3ee-4c4c-ab9c-7f37558d67b6', 'fefcd0fa-fbc2-487b-96d1-d68eaaa9a961', '/fileupload/goods/Original/0225366db44f4082b98439fcd904ea3f.jpg', '后支架', '50.00', '49.00', '3', '147.00');
INSERT INTO `ordergoods` VALUES ('e8d37437-d227-48bc-8569-7eb55dc2d712', 'ce824c67-5b04-48f1-8f4a-34fa44b4b679', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('f05bcc0d-141c-4b31-8b0e-c7e2a4b8b529', '7589585e-14be-48c3-84de-0c46429be23d', 'c3ea23da-d482-4e05-b50a-c6119b2c2f68', '/fileupload/goods/Original/0bb615b4a4b04c9ba0f14dea7251234e.png', '五芯工业插件', '50.00', '49.00', '1', '49.00');
INSERT INTO `ordergoods` VALUES ('ffd72736-48d0-4a43-abda-6f2b69501150', 'cfdfcd58-2580-42da-9d82-5920fd7f03eb', 'f3adad39-3c5e-45c7-8d61-1a74462db0fd', '/fileupload/goods/Original/888bb1d044e04ff3a2e6642f53b5f838.png', '电缆线', '50.00', '49.00', '1', '49.00');

-- ----------------------------
-- Table structure for orderpingjia
-- ----------------------------
DROP TABLE IF EXISTS `orderpingjia`;
CREATE TABLE `orderpingjia` (
  `GUID` varchar(36) NOT NULL,
  `orderid` varchar(36) NOT NULL,
  `pingjia` varchar(3000) DEFAULT NULL,
  `ordergoodsid` varchar(36) DEFAULT NULL,
  `grade` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of orderpingjia
-- ----------------------------
INSERT INTO `orderpingjia` VALUES ('4d18e996-b6fe-4292-aa50-edbe86f97a52', 'd3ab5cd9-86ec-41da-9ae1-81621de041a1', '晕晕乎乎的和以文会友', null, null);
INSERT INTO `orderpingjia` VALUES ('4e366c65-48ee-420d-897a-2e50acee6c4c', '956f23f5-a2c5-49a3-84a6-9ea93141ccbd', '抓紧时间jskj', null, null);
INSERT INTO `orderpingjia` VALUES ('4e68c593-05fa-443f-ab70-663326177b3e', 'c0c265b5-d539-488e-823a-287e2f3da2a5', 'vhgffrrr', null, null);
INSERT INTO `orderpingjia` VALUES ('60586e35-ef89-4b8a-a8af-186bd90dc4a9', '324b2678-b692-4147-9825-7e1529300b43', 'udhduudus', null, null);
INSERT INTO `orderpingjia` VALUES ('7bc8c1d3-3384-4352-a0f5-94b8e5f1d0c8', 'e2a75811-5bdb-4433-82c0-27529b8edc72', '好时患得患失是纠结', null, null);
INSERT INTO `orderpingjia` VALUES ('8ca1e49e-75c2-4a08-9219-f1435c1ff6fc', '18099b01-317c-4b2a-b268-da709efe6f3c', '“经常就觉得劫财劫色饥饿”', null, null);

-- ----------------------------
-- Table structure for qualificationtype
-- ----------------------------
DROP TABLE IF EXISTS `qualificationtype`;
CREATE TABLE `qualificationtype` (
  `typeid` varchar(36) COLLATE utf8_bin NOT NULL,
  `typename` varchar(50) COLLATE utf8_bin NOT NULL,
  `typelogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `sort` int(11) NOT NULL,
  `Isshow` bit(1) NOT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of qualificationtype
-- ----------------------------
INSERT INTO `qualificationtype` VALUES ('46927769-3473-4134-b675-cf26061dab34', '吊篮租赁企业安装资质', null, '0', '\0', '');
INSERT INTO `qualificationtype` VALUES ('d80fb66f-b4e0-4915-a15f-ebcab7b8cd75', '吊篮制造企业生产资质', null, '1', '\0', '1');

-- ----------------------------
-- Table structure for qzj_check
-- ----------------------------
DROP TABLE IF EXISTS `qzj_check`;
CREATE TABLE `qzj_check` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `WTDW` text COMMENT '委托单位',
  `WTRQ` text COMMENT '委托日期',
  `SYDW` text COMMENT '使用单位',
  `WTLXRDH` text COMMENT '委托联系人电话',
  `GCMC` text COMMENT '工程名称',
  `AZFZRDH` text COMMENT '安装负责人电话',
  `SGDD` text COMMENT '施工地点',
  `AZRQ` text COMMENT '安装日期',
  `AZDW` text COMMENT '安装单位',
  `BABH` text COMMENT '备案编号',
  `SCCJ` text COMMENT '生产厂家',
  `GGXH` text COMMENT '规格型号',
  `SBMC` text COMMENT '设备名称',
  `CCBH` text COMMENT '出厂编号',
  `JLDW` text COMMENT '监理单位',
  `JYSFZDS` text COMMENT '检验时附着道数',
  `JYSAZGD` text COMMENT '检验时安装高度',
  `JYSL` text COMMENT '检验数量',
  `JYLB` text COMMENT '检验类别',
  `JYYJ` text COMMENT '检验依据',
  `WTDWJSZL` text COMMENT '委托单位技术资料',
  `FWLX` text COMMENT '服务类型',
  `NYR` text COMMENT '年月日',
  `JCFY` text COMMENT '检测费用',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of qzj_check
-- ----------------------------
INSERT INTO `qzj_check` VALUES ('e6a70639-3676-4dec-a8f5-82796df04db5', 'value11', '2016-08-14 18:38:09', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '正常', '', '');
INSERT INTO `qzj_check` VALUES ('f4acead2-9b87-4c87-a393-dbe03a172b1f', 'value', '2016-08-14 18:39:00', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', 'qq', '定期检验,', '《建筑施工升降设备设施检验标准》  JGJ 305-2013,《起重机械安装改造重大维修监督检验规则》      TSG Q7016-2008,', '1、安装单位拆装资质证书及（副本）等级,2、安装单位安全生产许可证,', '加急', '22', '22');

-- ----------------------------
-- Table structure for recommended
-- ----------------------------
DROP TABLE IF EXISTS `recommended`;
CREATE TABLE `recommended` (
  `recommendedid` varchar(36) COLLATE utf8_bin NOT NULL,
  `recommendedtype` varchar(50) COLLATE utf8_bin NOT NULL,
  `recommendedgoods` varchar(255) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`recommendedid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of recommended
-- ----------------------------
INSERT INTO `recommended` VALUES ('00000000-0000-0000-0000-000000000001', 'index', '00000000-0000-0000-0000-000000000003');
INSERT INTO `recommended` VALUES ('00000000-0000-0000-0000-000000000002', 'index', '00000000-0000-0000-0000-000000000004');
INSERT INTO `recommended` VALUES ('00000000-0000-0000-0000-000000000003', 'index', '00000000-0000-0000-0000-000000000005');
INSERT INTO `recommended` VALUES ('0540f642-60d9-4ff0-a6f5-deb149cbe2c1', 'Index', '0b59aee8-f586-456b-a03f-ee23483e6cdc');
INSERT INTO `recommended` VALUES ('23b3c22d-373a-4bf3-9eda-00247dc64dc3', 'Index', 'aba8d8ab-1250-4c81-b2d1-99017264bc4a');
INSERT INTO `recommended` VALUES ('26e62efb-4445-4888-8634-cd0d40d1b830', 'Index', 'b7884dea-2d97-4eac-959d-c4d86bd9639b');
INSERT INTO `recommended` VALUES ('8496278e-b470-426c-8002-ac871f5ed064', 'Index', '1e019c90-fb51-4444-96ee-d2918c5a1dcc');
INSERT INTO `recommended` VALUES ('b209ae40-e977-4ef1-8ea5-97af2f7f4f1c', 'Index', '573b2c4b-eca9-47db-88f3-442a284cb939');
INSERT INTO `recommended` VALUES ('c934eabf-b07b-489a-8da8-b327cac1c3d7', 'Index', 'c32532a6-7b3b-4a8b-8695-37992763da31');
INSERT INTO `recommended` VALUES ('cb54a980-c04c-4836-afc6-e175665a75d8', 'Index', 'ff2ee05e-382c-4dec-a581-734f19c52c70');

-- ----------------------------
-- Table structure for safe_lock
-- ----------------------------
DROP TABLE IF EXISTS `safe_lock`;
CREATE TABLE `safe_lock` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `WTDW` text COMMENT '委托单位',
  `YPMC` text COMMENT '样品名称',
  `ZZCS` text COMMENT '制造厂商',
  `XHGG` text COMMENT '型号规格',
  `CCBH` text COMMENT '出厂编号',
  `JYRQ` text COMMENT '接样日期',
  `JYYJ` text COMMENT '检验依据',
  `JYJL` text COMMENT '检验结论',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of safe_lock
-- ----------------------------
INSERT INTO `safe_lock` VALUES ('af82fb44-db19-4d56-aa05-766c731b2d54', 'value1', '2016-08-14 18:51:03', '', '', '', '', '', '', '', '');
INSERT INTO `safe_lock` VALUES ('dd42b7d3-c929-4c68-9ffe-9a3817aba3ed', 'value', '2016-08-14 18:51:24', '', '', '1', '1', '1', '2', '22', '33');

-- ----------------------------
-- Table structure for staging_check
-- ----------------------------
DROP TABLE IF EXISTS `staging_check`;
CREATE TABLE `staging_check` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `GCMC` text COMMENT '工程名称',
  `SGDD` text COMMENT '施工地点',
  `SYDW` text COMMENT '使用单位',
  `JLDW` text COMMENT '监理单位',
  `SBMC` text COMMENT '设备名称',
  `AZDW` text COMMENT '安装单位',
  `SBXH` text COMMENT '设备型号',
  `SBBH` text COMMENT '设备编号',
  `SCCJ` text COMMENT '生产厂家',
  `CCRQ` text COMMENT '出厂日期',
  `ZZXKZ` text COMMENT '制造许可证',
  `JYGD` text COMMENT '检验高度',
  `GXJWYBH` text COMMENT '光学经纬仪编号',
  `GXJWYZK` text COMMENT '光学经纬仪状况',
  `NJBSBH` text COMMENT '扭矩扳手编号',
  `NJBSZK` text COMMENT '扭矩扳手状况',
  `SZZOBBH` text COMMENT '数字兆欧表编号',
  `SZZOBZK` text COMMENT '数字兆欧表状况',
  `WSDJBH` text COMMENT '温湿度计编号',
  `WSDJZK` text COMMENT '温湿度计状况',
  `FSYBH` text COMMENT '风速仪编号',
  `FSYZK` text COMMENT '风速仪状况',
  `YBKCBH` text COMMENT '游标卡尺编号',
  `YBKCZK` text COMMENT '游标卡尺状况',
  `GJC30BH` text COMMENT '钢卷尺30编号',
  `GJC30ZK` text COMMENT '钢卷尺30状况',
  `GJC5BH` text COMMENT '钢卷尺5编号',
  `GJC5ZK` text COMMENT '钢卷尺5状况',
  `GZC1BH` text COMMENT '钢直尺1编号',
  `GZC1ZK` text COMMENT '钢直尺1状况',
  `GZC2BH` text COMMENT '钢直尺2编号',
  `GZC2ZK` text COMMENT '钢直尺2状况',
  `SCBH` text COMMENT '塞尺编号',
  `SCZK` text COMMENT '塞尺状况',
  `JYJG` text COMMENT '检验结果',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of staging_check
-- ----------------------------
INSERT INTO `staging_check` VALUES ('88c21d5a-f62b-4110-92d0-302c615a4e3f', 'value111', '2016-08-14 19:04:12', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');
INSERT INTO `staging_check` VALUES ('ffd0f375-c542-4017-a2cc-a1df48b14f40', 'value', '2016-08-14 19:04:28', '1', '2', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '2', '3', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');

-- ----------------------------
-- Table structure for testing
-- ----------------------------
DROP TABLE IF EXISTS `testing`;
CREATE TABLE `testing` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `testingclientcompanyname` varchar(100) DEFAULT NULL,
  `testingclientcompanyaddr` varchar(100) DEFAULT NULL,
  `testinglinkname` varchar(100) DEFAULT NULL,
  `testingtel` varchar(100) DEFAULT NULL,
  `testingengineeringname` varchar(100) DEFAULT NULL,
  `testingengineeringaddr` varchar(100) DEFAULT NULL,
  `testingbuildercompany` varchar(100) DEFAULT NULL,
  `testingconstructioncompany` varchar(100) DEFAULT NULL,
  `testingcontent` varchar(100) DEFAULT NULL,
  `testingsize` int(11) DEFAULT NULL,
  `testingepitome` varchar(100) DEFAULT NULL,
  `testingmanufacturer` varchar(100) DEFAULT NULL,
  `testingequipmentnumber` varchar(100) DEFAULT NULL,
  `testingequipmenttype` varchar(100) DEFAULT NULL,
  `testingmountheight` varchar(100) DEFAULT NULL,
  `testingother` varchar(100) DEFAULT NULL,
  `testingtheway` varchar(100) DEFAULT NULL,
  `testingmailing` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of testing
-- ----------------------------
INSERT INTO `testing` VALUES ('2feb8a95-9847-4bfb-924e-d8169bfcdcc2', 'admin', '名称', '1', '姓名', '电话', '2', '3', '4', '5', '55', '6', '7', '8', '9', '1', '2', '3', '4', '6', '已处理', '', '2015-09-13 12:13:38', 'admin', null);
INSERT INTO `testing` VALUES ('37341261-ca25-47f9-b30a-40966cbc6077', '577c8982-c23b-405a-b204-ee12bdde7c95', '22', '', '44', '333333', '', '', '', '', '232234', '5', '', '', '', '', '', '', '234', '25235', '已处理', '', null, null, null);
INSERT INTO `testing` VALUES ('3a4c5948-cec7-4a3b-b6a1-33336799f8e8', '577c8982-c23b-405a-b204-ee12bdde7c95', '啊JJ', 'JJ了', '摸摸', '13726982121', 'JJ了', '考虑考虑', '考虑考虑', '模棱两可', '高处作业吊篮', '6', 'JJ了', '莫', 'JJ了', 'JJ了', 'JJ了', '兔子', '快递', '委托单位', '未处理', '\0', null, null, null);
INSERT INTO `testing` VALUES ('6bad987c-ea2e-485f-9dd4-d18f205aff75', '1f46314c-2fe9-4272-963b-4f2330c2daee', '哈哈哈疯疯癫癫', '反攻倒算啊啊', '房峰辉防晒霜', '打给他我鄂尔多斯', 'ETF SSD关于', '儿童DDT Re EF ft', '人的f恶儿童房但是', '而他的人员介绍人志颖', '高处作业吊篮', '25', '而奋斗', '而非的', '儿童房的', 'RF FF大多数', '人的盛衰荣辱同样', 'ET浴缸的委托人', '快递', '委托单位', '未处理', '\0', null, null, null);
INSERT INTO `testing` VALUES ('bd0ca351-3967-45f8-b52c-6892566e48cc', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '太阳', '举动', '哈喽', '15855668963', '阿鲁', '都去', '错过', '握笔', '高处作业吊篮', '25', 'ggu', '拉图', '258636', 'zlp', '44', 'uuj', '自取', '其它,jdjs', '未处理', '\0', null, null, null);
INSERT INTO `testing` VALUES ('de4393b6-b1a0-4540-b698-0f3844c2e817', '577c8982-c23b-405a-b204-ee12bdde7c95', 'hgg', 'ggg', 'ggg', '123466', 'ggg', 'hhh', 'ggg', 'ggg', '高处作业吊篮', '5', '', 'bnb', 'ttg', 'fgg', 'fft', 'rff', '快递', '', '未处理', '\0', null, null, null);

-- ----------------------------
-- Table structure for threelogin
-- ----------------------------
DROP TABLE IF EXISTS `threelogin`;
CREATE TABLE `threelogin` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Opened` varchar(256) DEFAULT NULL,
  `Type` varchar(255) DEFAULT NULL,
  `Userlogo` varchar(255) DEFAULT NULL,
  `usernickname` varchar(255) DEFAULT NULL,
  `UserName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of threelogin
-- ----------------------------

-- ----------------------------
-- Table structure for tower_crane
-- ----------------------------
DROP TABLE IF EXISTS `tower_crane`;
CREATE TABLE `tower_crane` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `GCMC` text COMMENT '工程名称',
  `SYDW` text COMMENT '使用单位',
  `SGDD` text COMMENT '施工地点',
  `JLDW` text COMMENT '监理单位',
  `AZDW` text COMMENT '安装单位',
  `AZFZR` text COMMENT '安装负责人',
  `SBMC` text COMMENT '设备名称',
  `SBXH` text COMMENT '设备型号',
  `ZZDW` text COMMENT '制造单位',
  `AZGZRQ` text COMMENT '安装告知日期',
  `CCBH` text COMMENT '出厂编号',
  `ZZXKZBH` text COMMENT '制造许可证编号',
  `CCRQ` text COMMENT '出厂日期',
  `BABH` text COMMENT '备案编号',
  `ZDEDQZL` text COMMENT '最大额定起重量',
  `EDLJ` text COMMENT '额定力矩',
  `XCZDBFSD` text COMMENT '小车最大变幅速度',
  `BZJGGSL` text COMMENT '标准节规格/数量',
  `JYSAZGD` text COMMENT '检验时安装高度',
  `ZDFD` text COMMENT '最大幅度',
  `YXDLGD` text COMMENT '允许独立高度',
  `AZFZDS` text COMMENT '安装附着道数',
  `DYDFQGD` text COMMENT '第一道附墙高度',
  `JYLB` text COMMENT '检验类别',
  `ZYSBMC1` text COMMENT '主要设备名称1',
  `ZYSBXH1` text COMMENT '主要设备型号1',
  `ZYSBBH1` text COMMENT '主要设备编号1',
  `ZYSBZT1` text COMMENT '主要设备状态1',
  `ZYSBMC2` text COMMENT '主要设备名称2',
  `ZYSBXH2` text COMMENT '主要设备型号2',
  `ZYSBBH2` text COMMENT '主要设备编号2',
  `ZYSBZT2` text COMMENT '主要设备状态2',
  `ZYSBMC3` text COMMENT '主要设备名称3',
  `ZYSBXH3` text COMMENT '主要设备型号3',
  `ZYSBBH3` text COMMENT '主要设备编号3',
  `ZYSBZT3` text COMMENT '主要设备状态3',
  `ZYSBMC4` text COMMENT '主要设备名称4',
  `ZYSBXH4` text COMMENT '主要设备型号4',
  `ZYSBBH4` text COMMENT '主要设备编号4',
  `ZYSBZT4` text COMMENT '主要设备状态4',
  `ZYSBMC5` text COMMENT '主要设备名称5',
  `ZYSBXH5` text COMMENT '主要设备型号5',
  `ZYSBBH5` text COMMENT '主要设备编号5',
  `ZYSBZT5` text COMMENT '主要设备状态5',
  `BZXMBHGS` text COMMENT '保证项目不合格数',
  `YBXMBHGS` text COMMENT '一般项目不合格数',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tower_crane
-- ----------------------------
INSERT INTO `tower_crane` VALUES ('0357bca4-40e3-465d-a8f1-84dfad2a0ce2', 'value', '2016-08-14 20:40:49', '', '', '', '', '', '', '', '', '', '', '', '', '4', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 'fg', null, null, null, null, null, null, null, null, null, null, null, null, '3', '');
INSERT INTO `tower_crane` VALUES ('81493a5b-ca6d-45c7-9982-d6d342c56149', 'value1', '2016-08-14 20:40:23', '2', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '', '');

-- ----------------------------
-- Table structure for train
-- ----------------------------
DROP TABLE IF EXISTS `train`;
CREATE TABLE `train` (
  `GUID` varchar(36) NOT NULL DEFAULT '',
  `userid` varchar(36) NOT NULL,
  `trainname` varchar(100) NOT NULL,
  `trainsex` varchar(2) NOT NULL,
  `trainculturaldegree` varchar(100) DEFAULT NULL,
  `trainbirthdate` datetime DEFAULT NULL,
  `trainservicelength` varchar(100) DEFAULT NULL,
  `trainphysicalcondition` varchar(100) DEFAULT NULL,
  `traintypeid` varchar(100) DEFAULT NULL,
  `trainID` varchar(100) NOT NULL,
  `traincompany` varchar(100) DEFAULT NULL,
  `trainpostcode` varchar(100) DEFAULT NULL,
  `traincompanyaddr` varchar(100) DEFAULT NULL,
  `trainlinkname` varchar(100) DEFAULT NULL,
  `traintel` varchar(100) DEFAULT NULL,
  `trainemail` varchar(100) DEFAULT NULL,
  `state` varchar(100) DEFAULT NULL,
  `ispay` bit(1) DEFAULT NULL,
  `operatetime` datetime DEFAULT NULL,
  `operator` varchar(36) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GUID`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of train
-- ----------------------------
INSERT INTO `train` VALUES ('1cda7437-8d3a-446d-bd47-b4d019534d1b', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '白天', 'f', '大专', '1986-05-23 00:00:00', '6', '良好', '电工', '3208667755', '俺', '214000', '来咯去苏州', '俺', '2580564896', '阿鲁特谢谢', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('235d4cde-2373-4e1f-87fb-6cec7b04f6bc', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '我', 'f', '本科', '1971-02-25 00:00:00', '3', '良好', '吊篮操作工', '2222222222', '我', '214000', '无锡', '我', '8888888', '123', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('3765a6f8-5929-415c-879c-1a85a5942e1c', '577c8982-c23b-405a-b204-ee12bdde7c95', 'ggg', 'm', 'hhg', '2015-09-05 00:00:00', '5', 'fgg', '00001', '45566688888855522', 'ffff', 'rfft', 'ggggg', 'ffff', 'yyhhh', 'ffggg', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('3a8e31ae-5442-4863-80d2-d50ce406ba1f', 'admin', '申请人', 'm', '', null, '', '', '0000100001', '33333333', '', '', '', '', ',,,', '', '已处理', '', '2015-09-09 18:50:52', 'admin', null);
INSERT INTO `train` VALUES ('5cab6c93-5483-479c-9b56-4f7fafb7b086', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '白天', 'm', '大专', '1986-05-14 00:00:00', '3', '良好', '电工', '320558964', '吕', '214000', '咯噢耶', '吕', '258663478', 'but我', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('6c2082fa-80ba-48de-ab12-61ae23075ff0', '3ac3ac2e-1597-4f46-8788-ee61af46f441', '太阳', 'f', '大专', '1980-03-21 00:00:00', '6', '良好', '00001', '320', '在这里', '214000', '太阳穴', '太阳', '3567908', 'ghjkt', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('902f170b-6f7a-49a6-91c9-5c782e360ef7', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '好了了了了了', 'm', '啊啦啦', '2001-12-14 00:00:00', '了了了了了了了了了了', '‘\\‘‘啊啊啊啊啊\\’’', '啊啊啊啊啊', '啊啊啊啊啊', '呃呃呃额额的', '噢噢噢哦哦', '啊call了了了', '呃呃呃额额的', '愧疚', '空军建军节', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('af999245-d9f8-4758-9deb-4dd61c4aa85c', '577c8982-c23b-405a-b204-ee12bdde7c95', '考虑考虑', 'm', '春节快乐', '2015-12-12 00:00:00', '21', '春节快乐', '吊篮操作工', '440981188711123525', 'JJ了', '12354', '考虑考虑', 'JJ了', '123456', '555', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('e2e865c1-f9d7-4c5b-9a8c-cb7b5cedb170', 'admin', '1', 'm', '', '2015-09-11 00:00:00', '', '', '00001', '2', '', '', '', '', '', '', '未处理', '\0', '2015-09-09 21:00:42', 'admin', null);
INSERT INTO `train` VALUES ('e4447a63-7dd0-4669-ae35-743b3bd9621c', '1f46314c-2fe9-4272-963b-4f2330c2daee', '护具就但是', 'm', '我是对的', '1890-08-14 00:00:00', '大大方方', '但腹股沟', '法国韩国', '使得法国hUI GD wwww Ed', '法国呼吁个', '双方共同', '但法国呼吁', '法国呼吁个', '洞若观火环境', '法规和技术事物', '未处理', '\0', null, null, null);
INSERT INTO `train` VALUES ('f2d906e3-1b6d-44e7-b087-00f13ab37ba3', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '有一些', 'm', '初中', '1985-03-12 00:00:00', '1', '好', '0000200001', '140429432145678908', '中国', '046312', '放哥哥哥哥', '儿童', '13456543212', '对的地方分分合合好', '未处理', '\0', null, null, null);

-- ----------------------------
-- Table structure for traintype
-- ----------------------------
DROP TABLE IF EXISTS `traintype`;
CREATE TABLE `traintype` (
  `typeid` varchar(36) COLLATE utf8_bin NOT NULL,
  `typename` varchar(50) COLLATE utf8_bin NOT NULL,
  `typelogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `sort` int(11) NOT NULL,
  `Isshow` bit(1) NOT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`typeid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of traintype
-- ----------------------------
INSERT INTO `traintype` VALUES ('00001', '吊篮操作工', null, '0', '\0', '1');
INSERT INTO `traintype` VALUES ('0000100001', '吊篮装调工', null, '0', '\0', '11');
INSERT INTO `traintype` VALUES ('00002', '电工', null, '0', '\0', '2');
INSERT INTO `traintype` VALUES ('0000200001', '焊工', null, '0', '\0', '22');
INSERT INTO `traintype` VALUES ('00003', '钳工', null, '0', '\0', '3');
INSERT INTO `traintype` VALUES ('0000300001', '车工', null, '0', '\0', '4');
INSERT INTO `traintype` VALUES ('4b58ae24-92b4-43b5-8eb9-122b815c2e7a', '砌筑工', null, '0', '\0', '');
INSERT INTO `traintype` VALUES ('771de7d0-e492-45c7-88f4-ad613f51967b', '木工', null, '0', '\0', '');
INSERT INTO `traintype` VALUES ('8dbeafcc-94a3-45cc-a90d-68c506652ea5', '防水工', null, '0', '\0', '');
INSERT INTO `traintype` VALUES ('c47ea83b-7c21-4bbd-abee-53fda4ff38a8', '涂装工', null, '0', '\0', '');

-- ----------------------------
-- Table structure for upfeedbackinfo
-- ----------------------------
DROP TABLE IF EXISTS `upfeedbackinfo`;
CREATE TABLE `upfeedbackinfo` (
  `guid` varchar(36) COLLATE utf8_bin NOT NULL,
  `userid` varchar(36) COLLATE utf8_bin NOT NULL,
  `content` varchar(500) COLLATE utf8_bin NOT NULL,
  `dt` datetime NOT NULL,
  `description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of upfeedbackinfo
-- ----------------------------
INSERT INTO `upfeedbackinfo` VALUES ('099ec687-2a13-40e1-bd90-9d397f0bab54', 'e38f126c-0051-4d93-b246-05d6297a75b5', '?????', '2015-08-31 21:57:21', '');
INSERT INTO `upfeedbackinfo` VALUES ('0d5e99d9-e5b7-479d-9d96-a77d8faa2911', '7fb0e7b9-42e9-464f-93c2-039c06160ad1', 'adjdsfj', '2015-08-22 15:36:07', '');
INSERT INTO `upfeedbackinfo` VALUES ('1d9e98dc-2d4c-45a1-8f61-ea1216eb74cc', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '放放风哥哥', '2015-11-23 13:13:03', '');
INSERT INTO `upfeedbackinfo` VALUES ('1db7a9d5-80ff-4cb2-8f20-88a963464dac', '7c887041-5286-439d-8090-ce1ad2a1ce0d', '????', '2015-08-29 13:03:47', '');
INSERT INTO `upfeedbackinfo` VALUES ('20c810ab-d417-45e2-8266-1dd4521978b7', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '就z?j?z?j?si?si?i', '2015-12-07 00:16:54', '');
INSERT INTO `upfeedbackinfo` VALUES ('2cf44597-fab3-4046-bebc-6df268301a02', '7c887041-5286-439d-8090-ce1ad2a1ce0d', '??', '2015-08-29 12:57:04', '');
INSERT INTO `upfeedbackinfo` VALUES ('36c10860-0bd9-4fa0-a84c-0aff349ac78f', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '患得患失是一', '2015-09-24 17:32:13', '');
INSERT INTO `upfeedbackinfo` VALUES ('46d9e0e1-60ba-47d1-af1a-4d8e83dc4e12', '60ed6597-1993-47a3-8360-4096993799d6', '共和军', '2015-09-11 22:30:58', '');
INSERT INTO `upfeedbackinfo` VALUES ('7e7c444c-ba7a-4cb6-aee5-44f0269d8b39', 'eb6b3739-506a-4a04-9b00-8c859e3ec45e', '仿佛听到的人', '2015-11-27 00:30:07', '');
INSERT INTO `upfeedbackinfo` VALUES ('7f3f4bc7-8664-46d2-98eb-fb558fb229ec', '7c887041-5286-439d-8090-ce1ad2a1ce0d', '????', '2015-08-29 13:02:34', '');
INSERT INTO `upfeedbackinfo` VALUES ('a36198a8-ff81-481d-87ab-85b8b8278343', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '关怀呵护', '2015-11-23 13:11:11', '');
INSERT INTO `upfeedbackinfo` VALUES ('b40b0930-bb62-47b1-a585-787226e0cbc6', '7c887041-5286-439d-8090-ce1ad2a1ce0d', 'gghhh', '2015-08-29 12:56:51', '');
INSERT INTO `upfeedbackinfo` VALUES ('e282b80d-d70d-4ca9-ae2d-e7f57e175514', '8dfa10a3-fdd3-4a78-89f7-28af9996387a', '1', '2015-08-22 15:19:53', '');
INSERT INTO `upfeedbackinfo` VALUES ('eaad9eed-c6df-4152-a6c4-e5f0160b699a', '29591c2b-5c89-42c8-8cd4-175aeb78a60f', '啊啊啊吧的', '2015-11-07 14:26:51', '');
INSERT INTO `upfeedbackinfo` VALUES ('f368b492-7204-4a27-965f-f51ada8b6d63', 'e5f37957-8397-478b-b917-d60dd07804fe', '\"??\"', '2015-08-29 12:43:13', '');
INSERT INTO `upfeedbackinfo` VALUES ('f85db246-4be6-4e45-88c1-6a1be189cfc6', '8dfa10a3-fdd3-4a78-89f7-28af9996387a', '123131313', '2015-08-22 15:20:38', '');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `userid` varchar(36) COLLATE utf8_bin NOT NULL DEFAULT '',
  `userlogo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `username` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `usernickname` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `userphone` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `usersex` varchar(2) COLLATE utf8_bin DEFAULT NULL,
  `userpoints` int(11) NOT NULL,
  `userconsumption` double(11,2) NOT NULL,
  `password` varchar(50) COLLATE utf8_bin NOT NULL,
  `addrid` varchar(36) COLLATE utf8_bin DEFAULT NULL COMMENT '用户的默认收货地址 对应地址编号',
  `gradeid` varchar(36) COLLATE utf8_bin DEFAULT NULL,
  `remark` varchar(2000) COLLATE utf8_bin DEFAULT NULL,
  `openid` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `type` varchar(2) COLLATE utf8_bin DEFAULT NULL,
  `ishuanxin` bit(1) NOT NULL DEFAULT b'0',
  `hxpassword` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('0b04ed67-9823-4647-90df-6eb670658953', '', '', '', '18636150471', '', '0', '0.00', '123456', '', '8dfa10a3-fdd3-4a78-89f7-28af9996388c', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('15d108d6-479b-4e1e-9346-5479cc24a198', '', '', '', '15234022725', '', '0', '0.00', '111111', '', null, null, null, null, '', '475815');
INSERT INTO `user` VALUES ('167a0818-ea44-45bd-83b9-e484e710addd', '', '', '', '13858582303', '', '0', '0.00', '326441', '', null, null, null, null, '', '894946');
INSERT INTO `user` VALUES ('1bbd62df-d47a-4d65-99ed-41f16181684a', '', '', null, '', '', '0', '0.00', '', '3c949b57-1b83-40a9-a6b7-5d96f5c72ad8', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, '5391812566', '3', '', '116287');
INSERT INTO `user` VALUES ('1f46314c-2fe9-4272-963b-4f2330c2daee', '0FB952F2CF6AE7C5.jpg', '有何贵干', '哈哈哈', '18635074577', 'f', '45', '0.00', '123456', '4f680591-87d1-43d1-99f2-9355004b2c03', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('1f790a25-8ec4-4296-ba7b-a042f5b52b8e', '', '', '', '13429703151', '', '0', '0.00', 'qqq456789qqq', '', null, null, null, null, '', '264059');
INSERT INTO `user` VALUES ('29591c2b-5c89-42c8-8cd4-175aeb78a60f', 'A3883C51A736287B.jpg', '远方', '李彤', '13453123293', 'o', '271', '0.00', '888888', '91324528-6dfc-491e-a804-96d7e84a04ab', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('366e9a99-8147-4a33-9058-a58687890c09', '', '', '', '13244554455', '', '97', '0.00', '123123', 'e5e25e07-a789-406b-8b47-b644c9ae86da', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('3ac3ac2e-1597-4f46-8788-ee61af46f441', '', '', '', '15052218101', '', '0', '0.00', 'qmm198733', '', null, null, null, null, '', '634063');
INSERT INTO `user` VALUES ('577c8982-c23b-405a-b204-ee12bdde7c95', 'B7BEFA7683795A81.jpg', '越狱兔', '啊啊啊‘急急急捷克共和国', '13726982180', 'm', '490', '0.00', '123456', '9896a57e-965c-4a74-8f22-aad276f2b8f2', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '', '153915');
INSERT INTO `user` VALUES ('60ed6597-1993-47a3-8360-4096993799d6', '95EE8113C82EF322.png', '李 中', '124', '15575757575', 'f', '0', '0.00', '321321', '8576df11-575e-4355-a7ce-fa008bc048ad', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('6ad19cc5-14a0-4743-ab88-4b3c10455703', '20F82FF4B26207CC.png', 'ldq', 'lidq', '15575394951', 'm', '801', '0.00', '123123', '614ed591-ae1d-446d-8ad7-8893a77cb639', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '', '391249');
INSERT INTO `user` VALUES ('79b20f7d-bfd6-425e-b6e1-3b2cd18d1740', '', '', '', '18762029260', '', '0', '0.00', '1995115', '', null, null, null, null, '\0', null);
INSERT INTO `user` VALUES ('7fb0e7b9-42e9-464f-93c2-039c06160ad1', '952FCBD2AF661BDC.png', '家家', '中华人民共和国', '15234037253', '1', '123', '0.00', '3', '4c823cf7-bea8-409c-b153-0325f056f8ad', '8dfa10a3-fdd3-4a78-89f7-28af9996388c', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('8ca1853b-3234-4e0a-bc45-b454befcb72d', '', '', '', '15759591028', '', '0', '0.00', '1271265166', '', null, null, null, null, '', '860389');
INSERT INTO `user` VALUES ('8dfa10a3-fdd3-4a78-89f7-28af9996387a', '952FCBD2AF661BDC.png', '家家', '中华人民共和国', '15234037253', '1', '0', '0.00', '111', '19193972-e806-4cfb-bf1c-38bb50ccd7ec', '8dfa10a3-fdd3-4a78-89f7-28af9996388c', null, null, null, '\0', null);
INSERT INTO `user` VALUES ('9384d577-dbdb-4d20-90ce-3fdc2a889191', '', '', '单纯--变质', '', '', '0', '0.00', '', '', null, null, 'uid', '3', '', '747051');
INSERT INTO `user` VALUES ('b2f8fe93-bdec-450d-90a4-d55683e265c5', '', '', '', '13363449844', '', '0', '0.00', '111111', '', null, null, null, null, '', '611171');
INSERT INTO `user` VALUES ('b7c74be9-77af-402c-877c-217c27799cad', '', '', '', '13951509694', '', '0', '0.00', '586588', '', null, null, null, null, '', '837053');
INSERT INTO `user` VALUES ('bc310417-dd53-4f2f-b576-1128272e927f', '', '', '', '18832751817', '', '0', '0.00', '123456', '', null, null, null, null, '', '127112');
INSERT INTO `user` VALUES ('c10611c3-9a1f-4dc0-af7a-0e025706138e', '7BD74B4A06E09344.png', '', '在南宁市', '', '', '0', '0.00', '', '', null, null, '1910317221', '3', '', '272683');
INSERT INTO `user` VALUES ('c964d548-4908-4fc6-a078-75a3d00f3644', '', '', '', '18521301587', '', '0', '0.00', '11235813', '61dc24fa-583f-40d5-802f-a87173d930e3', null, null, null, null, '\0', null);
INSERT INTO `user` VALUES ('d9ad4789-6e5c-4703-b5b8-f6afcce57f81', '37AA38023C5C5529.png', 'jokes ', 'sjxjq ', '17703417342', 'f', '0', '0.00', '111111', '5a03f1cd-03fa-4a5a-8ec1-409df8ebdb80', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '', '612727');
INSERT INTO `user` VALUES ('ead5c475-6fbc-44f1-b4e7-ef8abf1aa3fe', '', '', '', '15298894069', '', '0', '0.00', '123456', 'e5c72c98-fbfd-4414-8990-e8ee6818af7c', null, null, null, null, '', '092100');
INSERT INTO `user` VALUES ('eb6b3739-506a-4a04-9b00-8c859e3ec45e', 'B44EF44580B31988.jpg', '铁观音', '有意义', '15934152105', 'o', '489', '137.90', '222222', 'ab92627a-022f-48d0-88ed-150dcb846328', '1eec78a5-f3f5-475f-bc32-06fe23c434fa', null, null, null, '', '381138');
INSERT INTO `user` VALUES ('edede613-0a77-4981-9fb0-ecb38fb990b5', '', '', '', '18648395085', '', '0', '0.00', '15047324524', '', null, null, null, null, '', '693036');

-- ----------------------------
-- Table structure for winow_check
-- ----------------------------
DROP TABLE IF EXISTS `winow_check`;
CREATE TABLE `winow_check` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `GCMC` text COMMENT '工程名称',
  `SGDD` text COMMENT '施工地点',
  `SYDW` text COMMENT '使用单位',
  `AZDW` text COMMENT '安装单位',
  `SBMC` text COMMENT '设备名称',
  `AZFZR` text COMMENT '安装负责人',
  `SBXH` text COMMENT '设备型号',
  `SBBH` text COMMENT '设备编号',
  `SCCJ` text COMMENT '生产厂家',
  `CCRQ` text COMMENT '出厂日期',
  `JYGD` text COMMENT '检验高度',
  `JYLB` text COMMENT '检验类别',
  `DZCSYBH` text COMMENT '电阻测试仪编号',
  `DZCSYZK` text COMMENT '电阻测试仪状况',
  `SZZOBBH` text COMMENT '数字兆欧表编号',
  `SZZOBZK` text COMMENT '数字兆欧表状况',
  `JMSJJBH` text COMMENT '精密声级计编号',
  `JMSJJZK` text COMMENT '精密声级计状况',
  `SZWYBBH` text COMMENT '数字万用表编号',
  `SZWYBZK` text COMMENT '数字万用表状况',
  `DZMBBH` text COMMENT '电子秒表编号',
  `DZMBZK` text COMMENT '电子秒表状况',
  `FSJBH` text COMMENT '风速计编号',
  `FSJZK` text COMMENT '风速计状况',
  `WSDJBH` text COMMENT '温湿度计编号',
  `WSDJZK` text COMMENT '温湿度计状况',
  `YBKCBH` text COMMENT '游标卡尺编号',
  `YBKCZK` text COMMENT '游标卡尺状况',
  `GJC30BH` text COMMENT '钢卷尺30编号',
  `GJC30ZK` text COMMENT '钢卷尺30状况',
  `GJC5BH` text COMMENT '钢卷尺5编号',
  `GJC5ZK` text COMMENT '钢卷尺5状况',
  `JYJG` text COMMENT '检验结果',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of winow_check
-- ----------------------------
INSERT INTO `winow_check` VALUES ('8306fb15-d035-4f47-80c7-dd6d81aa6ac5', 'value1', '2016-08-14 21:11:46', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');
INSERT INTO `winow_check` VALUES ('df7ed708-00c2-4c96-9cfe-086f5bc000ff', 'value', '2016-08-14 21:12:06', '1', '2', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '2', '', '', '', '', '', '', '', '', '', '', '', '', '4', '3');

-- ----------------------------
-- Table structure for wt_check
-- ----------------------------
DROP TABLE IF EXISTS `wt_check`;
CREATE TABLE `wt_check` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `WTDWMC` text COMMENT '委托单位名称',
  `WTDWDZ` text COMMENT '委托单位地址',
  `LXR` text COMMENT '联系人',
  `LXDH` text COMMENT '联系电话',
  `GCMC` text COMMENT '工程名称',
  `GCDZ` text COMMENT '工程地址',
  `SGDW` text COMMENT '施工单位',
  `SGDZ` text COMMENT '施工地址',
  `JYNR` text COMMENT '检验内容',
  `JYSL` text COMMENT '检验数量',
  `SCCJ` text COMMENT '生产厂家',
  `SBBH` text COMMENT '设备编号',
  `SBXH` text COMMENT '设备型号',
  `AZGD` text COMMENT '安装高度',
  `QT` text COMMENT '其它',
  `QBGFS` text COMMENT '取报告方式',
  `BGTD` text COMMENT '报告投递',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of wt_check
-- ----------------------------
INSERT INTO `wt_check` VALUES ('77be214e-ec07-465d-8c29-5aaa34cf3128', 'value1', '2016-08-14 21:55:10', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '');
INSERT INTO `wt_check` VALUES ('f3dda90c-a5f0-4dd7-a164-4efaa9396b5d', 'value', '2016-08-14 21:55:33', '3', '2', '', '', '', '', '', '', '附着式升降脚手架,安全锁,', '', '', '', '', '', '', '自取,快递,111', '委托单位,222');

-- ----------------------------
-- Table structure for xsweit_check
-- ----------------------------
DROP TABLE IF EXISTS `xsweit_check`;
CREATE TABLE `xsweit_check` (
  `Guid` char(36) NOT NULL,
  `userid` char(255) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  `CPMC` text COMMENT '产品名称',
  `GGXH` text COMMENT '规格型号',
  `WTDW` text COMMENT '委托单位',
  `LXR` text COMMENT '联系人',
  `SCDW` text COMMENT '生产单位',
  `LXDH` text COMMENT '联系电话',
  `CPBH` text COMMENT '产品编号',
  `WTRQ` text COMMENT '委托日期',
  `DWDZ` text COMMENT '单位地址',
  `WTJYYQ` text COMMENT '委托检验要求',
  `JYYJ` text COMMENT '检验依据',
  `JYFY` text COMMENT '检验费用',
  `YQWCRQ` text COMMENT '要求完成日期',
  `PHWCXM` text COMMENT '配合完成项目',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of xsweit_check
-- ----------------------------
INSERT INTO `xsweit_check` VALUES ('4ef7aa75-c209-419b-8b32-a9266209941f', 'value', '2016-08-14 22:11:39', '5', '6', '7', '8', '8', '2', '9', '9', '0', '9', '2', '1', '1', '2');
INSERT INTO `xsweit_check` VALUES ('9adb815e-58d6-4a96-bc3e-0dab49767eba', 'value1', '2016-08-14 22:11:07', '', '', '', '', '', '', '', '', '', '', '', '', '', '');
