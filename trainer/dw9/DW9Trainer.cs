using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dw9
{
    public partial class DW9Trainer : Form
    {
        public readonly string[] Names = {
            "夏侯惇",
            "典韦",
            "司马懿",
            "张辽",
            "曹操",
            "周瑜",
            "陆逊",
            "孙尚香",
            "甘宁",
            "孙坚",
            "赵云",
            "关羽",
            "张飞",
            "诸葛亮",
            "刘备",
            "貂蝉",
            "吕布",
            "许褚",
            "夏侯渊",
            "徐晃",
            "张郃",
            "曹仁",
            "曹丕",
            "太史慈",
            "吕蒙",
            "黄盖",
            "周泰",
            "凌统",
            "孙策",
            "孙权",
            "马超",
            "黄忠",
            "魏延",
            "关平",
            "庞统",
            "董卓",
            "袁绍",
            "张角",
            "甄宓",
            "小乔",
            "月英",
            "孟获",
            "蔡文姬",
            "大乔",
            "姜维",
            "贾诩",
            "司马师",
            "司马昭",
            "邓艾",
            "王元姬",
            "钟会",
            "诸葛诞",
            "夏侯霸",
            "郭淮",
            "丁奉",
            "刘禅",
            "星彩",
            "练师",
            "马岱",
            "祝融",
            "关索",
            "鲍三娘",
            "庞德",
            "王异",
            "郭嘉",
            "徐庶",
            "左慈",
            "乐进",
            "李典",
            "鲁肃",
            "韩当",
            "关兴",
            "张苞",
            "关银屏",
            "贾充",
            "文鸯",
            "张春华",
            "于禁",
            "朱然",
            "法正",
            "陈宫",
            "吕玲绮",
            "荀彧",
            "曹休",
            "满宠",
            "荀攸",
            "程普",
            "徐盛",
            "周仓",
            "辛宪英",
            "袁术",
            "夏侯姬",
            "董白"
        };

        private lib.TrainerLib t = new lib.TrainerLib();

        public DW9Trainer()
        {
            InitializeComponent();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            try
            {
                t.GameProcess.Dispose();
            }
            catch (Exception) {

            }
            if (!t.FindProcess("DW9.exe", "Dynasty Warriors 9"))
            {
                lbl_status.Text = "没有找到进程";
                return;
            }
            Console.WriteLine(t.GameProcess.MainWindowTitle);
            var addr = t.GameProcess.MainModule.BaseAddress.ToInt64();
            var hexAddr = Convert.ToString(addr, 16).ToUpper();
            lbl_status.Text = string.Format("PID: {0}\nBase: {1}", t.GameProcess.Id, hexAddr);
        }

        /// <summary>
        /// 获取当前人物ID
        /// </summary>
        /// <returns></returns>
        private Byte GetCharacterId()
        {
            var addr = t.GameProcess.MainModule.BaseAddress.ToInt64() + 0x1ABE198;
            byte id = t.ReadByte(addr);
            return id;
        }

        private void btn_read_character_Click(object sender, EventArgs e)
        {
            var id = GetCharacterId();
            if (id < Names.Length)
            {
                lbl_character.Text = string.Format("ID={0}\nNAME={1}", id, Names[id]);
            }
            else
            {
                lbl_character.Text = string.Format("错误。ID={0}", id);
            }
            
        }

        /// <summary>
        /// 获取【强化点数】内存地址
        /// </summary>
        /// <returns></returns>
        private Int64 GetPointsAddr()
        {
            var addr = t.GameProcess.MainModule.BaseAddress.ToInt64() + 0x19DC8F8;
            var id = GetCharacterId();
            addr = (Int64)(t.ReadUInt64(addr) + (UInt64)(id * 0x1C0 + 0x132));
            return addr;
        }

        private void btn_points_load_Click(object sender, EventArgs e)
        {
            var addr = GetPointsAddr();
            var points = t.ReadUInt32(addr);
            tb_points.Text = string.Format("{0}", points);
        }

        private void btn_points_save_Click(object sender, EventArgs e)
        {
            try
            {
                var points = Convert.ToUInt32(tb_points.Text);
                var addr = GetPointsAddr();
                t.Write(addr, points);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
