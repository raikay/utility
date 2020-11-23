﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace WordExportDemo.Tests
{
    public class WtTest
    {
        public static void Test()
        {
            Console.WriteLine($"实际用例");
            Stopwatch sw = new Stopwatch();
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "gs","博客园Deeround"},
                { "xmgk","博客园Deeround来函申请办理 应急抢险治理工程项目竣工结（决）算，该项目已完工并通过项目初步验收，现拟按程序采取政府购买服务方式开展评审。"},
                { "sqje","1417.4"},
                { "psnr",@"1.对项目建设程序进行评审，包括：审核项目单位是否取得可研、初步设计及概算、建设用地等批准文件；
2.对项目建设组织管理情况进行评审，包括：（1）审核项目单位是否严格执行项目法人制、招投标制、合同制、监理制等基本建设管理制度；（2）审核是否办理施工许可证；（3）审核是否办理竣工验收（单项难收及综合验收）。
3.对项目建设资金到位和使用情况进行评审，包括：审核建设资金来源及到位情况和审核建设资金使用及管理是否合规。
4.对项目财务管理及会计核算情况进行评审，包括：（1）审核项目财务管理和会计核算是否按基建财务及会计制度执行；（2）审核会计账簿、科目及账户的设置是否符合规定，项目建设中的材料、设备采购等手续是否齐全，记录是否完整；（3）审核资金使用、费用列支是否符合有关规定。
5.对建筑安装工程投资进行评审，包括：（1）审核送审建安工程投资各子项是否与工程结算审定投资一致及各子项的明细核算是否符合要求；（2）审核预付工程款、预付备料款抵扣是否准确，库存材料、应付工程款等明细账的组成内容是否真实、准确、完整；（3）审核项目单位是否编制工程进度款支付计划并按进度款审查意见支付工程款，是否取得合法凭证，是否按合同规定预留质保金；（4）对有甲供材料的项目，审核工程结算审定投资是否包括甲供材料费用；（5）审核项目单位代垫款项是否在工程结算款中扣回。
6.对设备投资进行评审，包括：（1）审核项目单位对设备的采购是否有相应的控制制度并有效执行；（2）审核设备采购的品种、规格是否与初步设计相符合，是否存在增加数量、提高标准现象；（3）审核设备入库、保管、出库是否建立相应的内部管理制度并有效执行；（4）审核设备的购买价、运杂费和采购保管费是否按规定计入成本；（5）审核设备采购、安装调试过程中所发生的各项费用，是否包括在设备采购合同内，进口设备各项费用是否列入设备购置成本；（6）审核设备投资支出是否按单项工程和设备的类别、品名、规格等进行明细核算；（7）审核与设备投资支出相关的内容如器材采购、采购保管费、库存设备、库存材料、材料成本差异、委托加工器材等核算是否遵循基本建设财务会计制度；（8）审核列入房屋建筑物的附属设备，如暖气、通风、卫生、照明、煤气等建设，是否已按规定列入建筑安装工程投资。
7.对待摊投资进行评审，包括：（1）审核待摊投资各子项费用是否属于本项目开支范围，费用是否按规定标准控制，支出凭证是否合规；（2）审核待摊投资各子项费用的结算是否正确。
8.对其他相关事项进行评审，包括：（1）审核交付使用资产的成本计算是否正确及交付是否符合条件；（2）审核转出投资、待核销基建支出的成本计算是否正确及转销是否合理、合规；（3）审核收尾工程是否属于已批准的工程内容，预留费用是否经工程造价咨询机构进行了预算审核。
9.对竣工财务决算报表进行评审，包括：（1）审核决算报表的编制依据和方法是否符合相关规定；（2）审核决算报表所列有关数字是否齐全、完整、真实，勾稽关系是否正确；（3）审核竣工财务决算说明书编制是否真实、客观，内容是否完整。
10.对概算执行情况进行评审，包括：（1）审核投资规模、生产能力、设计标准、建设用地、建筑面积、主要设备、配套工程等是否与批准概算相一致；（2）审核子项概算有无相互调剂使用，各项开支是否符合标准，有无提高标准、扩大规模和计划外项目；（3）审核追加概算的过程、原因及其合规性、真实性。
"},
                { "gzyq",@"1. 收到委托书后在10天内报送评审方案，评审完成后需提交评审报告纸质件7份及电子文档。
2.评审报告主要内容需包括：（1）评审范围及内容；（2）评审依据；（3）项目概况：项目批复情况，项目实施规模及内容，项目开工、完工时间及竣工验收情况，项目参建单位等；（4）评审结论：项目建设程序执行情况；项目基本建设管理制度执行情况；项目建设资金到位和使用情况；项目财务管理及会计核算情况；审定投资及审增（减）原因；（5）存在的问题及建议；（6）重要事项说明；（7）评审报告附件：经项目单位盖章确认的竣工财务决算评审明细表、项目概况表、竣工财务决算表、交付使用资产总表及交付使用资产明细表、项目单位对评审报告的反馈意见、评审机构对项目单位反馈意见的意见、项目前期审批文件。
"},
                { "sjyq","从收告之日起20天内完成。"},
                { "fybz","下浮20%ｘ难度系数0.9。"},
            };
            //明细数据
            IList<Dictionary<string, object>> mx = new List<Dictionary<string, object>>();
            for (int i = 0; i < 10; i++)
            {
                mx.Add(new Dictionary<string, object>() {
                    { "a",i},
                    { "b","项目概况表项目概况表项目概况表项目概况表项目概况表"},
                    { "c","评审中"},
                });
            }
            data.Add("mx", mx);
            sw.Start();
            string root = System.AppDomain.CurrentDomain.BaseDirectory;
            WordHelper.Export(root + Path.Combine("Templates", "temp_wt.docx"), root + "temp_wt_out.docx", data);
            sw.Stop();
            var time = sw.ElapsedMilliseconds;
            Console.WriteLine($"耗时：{time}毫秒");
        }
    }
}