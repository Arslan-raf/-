using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Рафиков_СРВ
{
    public partial class Form1 : Form
    {

        int minute, second;
        int minute2, second2;
        int minute3, second3;
        int active = 11;
        double stage = 1;
        int x1, y1;
        int x2, y2;
        string B1 = "Статья 272. Неправомерный доступ к компьютерной информации";
        string C1 = "Статья 273. Создание, использование и распространение вредоносных компьютерных программ";
        string D1 = "Статья 274. Нарушение правил эксплуатации средств хранения, обработки или передачи компьютерной информации и информационно-телекоммуникационных сетей";
        string E1 = "Статья 274.1. Неправомерное воздействие на критическую информационную инфраструктуру РФ";
        string F1 = "Статья 159.6. Мошенничество в сфере компьютерной информации";
      
        string B12 = "Штраф в размере до двухсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до восемнадцати месяцев, либо исправительные работы на срок до одного года, либо ограничение свободы на срок до двух лет, либо принудительные работы на срок до двух лет, либо лишение свободы на тот же срок";
        string B13 = "Штраф в размере от ста тысяч до трехсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период от одного года до двух лет, либо исправительные работы на срок от одного года до двух лет, либо ограничение свободы на срок до четырех лет, либо принудительные работы на срок до четырех лет, либо лишение свободы на тот же срок";
        string B14 = "Штраф в размере до пятисот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до трех лет с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до трех лет, либо ограничение свободы на срок до четырех лет, либо принудительные работы на срок до пяти лет, либо лишение свободы на тот же срок";
        string B15 = "Лишение свободы на срок до семи лет";
        string B16 = "Уголовная ответственность за такие последствия наступает в случае, если лицо предвидело возможность их наступления, но без достаточных к тому оснований самонадеянно рассчитывало на их предотвращение, или если лицо не предвидело, но должно было и могло предвидеть возможность наступления этих последствий";
        
        
        string C12 = "Ограничение свободы на срок до четырех лет, либо принудительные работы на срок до четырех лет, либо лишение свободы на тот же срок со штрафом в размере до двухсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до восемнадцати месяцев";
        string C13 = "Ограничение свободы на срок до 4 лет, либо принуд. работы на срок до 5 лет с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до 3 лет или без такового, либо лишение свободы на срок до 5 лет со штрафом в размере от 100.000 до 200.000 рублей или в размере заработной платы или иного дохода осужденного за период от 2 до 3 лет или без такового и с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до 3 лет или без такового";
        string C14 = "Лишение свободы на срок до семи лет";
        string C15 = "Уголовная ответственность возникает уже в результате создания, использования или распространения программы, независимо от того, наступили ли в результате этого какие-либо общественно опасные последствия";

        string D12 = "Штраф в размере до пятисот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до восемнадцати месяцев, либо исправительные работы на срок от шести месяцев до одного года, либо ограничение свободы на срок до двух лет, либо принудительные работы на срок до двух лет, либо лишение свободы на тот же срок";
        string D13 = "Принудительные работы на срок до пяти лет либо лишение свободы на тот же срок";
        string D14 = "Ответственность по данному виду деяния наступает только в том случае, если в результате этих действий причиняется крупный ущерб";

        string E12 = "Принудительные работы на срок до пяти лет с ограничением свободы на срок до двух лет или без такового либо лишение свободы на срок от двух до пяти лет со штрафом в размере от пятисот тысяч до одного миллиона рублей или в размере заработной платы или иного дохода осужденного за период от одного года до трех лет";
        string E13 = "Предусмотрены принудительные работы на срок до пяти лет с ограничением свободы на срок до двух лет или без такового либо лишение свободы на срок от двух до пяти лет со штрафом в размере от пятисот тысяч до одного миллиона рублей или в размере заработной платы или иного дохода осужденного за период от одного года до трех лет даже в случае если деяния не повлекли причинение вреда критической информационной инфраструктуре Российской Федерации";
        string E14 = "Предусмотрено наказание в случае, если деяния повлекли причинение вреда критической информационной инфраструктуре Российской Федерации";
        string E15 = "Принудительные работы на срок до пяти лет со штрафом в размере от пятисот тысяч до одного миллиона рублей или в размере заработной платы или иного дохода осужденного за период от одного года до трех лет и с ограничением свободы на срок до двух лет или без такового либо лишение свободы на срок от двух до шести лет со штрафом в размере от пятисот тысяч до одного миллиона рублей или в размере заработной платы или иного дохода осужденного за период от одного года до трех лет"; 
        string E16 = "Предусмотрено наказание в случае, если деяния повлекли причинение вреда критической информационной инфраструктуре Российской Федерации";
        string E17 = "Принудительные работы на срок до пяти лет с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до трех лет или без такового либо лишение свободы на срок до шести лет с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до трех лет или без такового";
        string E18 = "Лишение свободы на срок от трех до восьми лет с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до трех лет или без такового";
        string E19 = "Лишение свободы на срок от пяти до десяти лет с лишением права занимать определенные должности или заниматься определенной деятельностью на срок до пяти лет или без такового";

        string F12 = "Штраф в размере до ста двадцати тысяч рублей или в размере заработной платы или иного дохода осужденного за период до одного года, либо обязательными работами на срок до трехсот шестидесяти часов, либо исправительные работы на срок до одного года, либо ограничение свободы на срок до двух лет, либо принудительные работы на срок до двух лет, либо арест на срок до четырех месяцев";
        string F13 = "Штраф в размере до трехсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до двух лет, либо обязательные работы на срок до четырехсот восьмидесяти часов, либо исправительные работы на срок до двух лет, либо принудительные работы на срок до пяти лет с ограничением свободы на срок до одного года или без такового, либо лишение свободы на срок до пяти лет с ограничением свободы на срок до одного года или без такового";
        string F14 = "Штраф в размере от ста тысяч до пятисот тысяч рублей или в размере заработной платы или иного дохода осужденного за период от одного года до трех лет, либо принудительные работы на срок до пяти лет с ограничением свободы на срок до двух лет или без такового, либо лишение свободы на срок до шести лет со штрафом в размере до восьмидесяти тысяч рублей или в размере заработной платы или иного дохода осужденного за период до шести месяцев либо без такового и с ограничением свободы на срок до полутора лет либо без такового";
        string F15 = "Лишение свободы на срок до десяти лет со штрафом в размере до одного миллиона рублей или в размере заработной платы или иного дохода осужденного за период до трех лет либо без такового и с ограничением свободы на срок до двух лет либо без такового";

        public Form1()
        {
            InitializeComponent();
          
            //timer1.Interval = 500;
            minute = 0;
            second = 0;
            minute3 = 0;
            second3 = 0;
            //  second_label.Text = "00";
            //minute_label.Text = "00";
            timer2.Enabled = true;
            timer3.Enabled = true;
            active = 11;
            Random r = new Random();
            int[] kek = new int[11];
            active_textBox.Text = "11";
            active_textBox2.Text = "0";
            //для графика



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void algorithm_label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void result_button_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            textBox1.Enabled = true;
            label23.Enabled = true;
            label24.Enabled = true;
            textBox2.Enabled = true;
            Start_button.Enabled = true;
            ez_game.Enabled = true;



            ///////////////////////////////////////////////////////////////////////////
            if ((radioButton1.Checked) || (radioButton2.Checked)|| (radioButton3.Checked)|| (radioButton4.Checked)) {
                textBox1.Text = B1;
                textBox2.Text = B12;
            }
           
            if (    ((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked)) && ((checkBox1.Checked )||(checkBox2.Checked))   )
            {
                textBox1.Text = B1;
                textBox2.Text = B13;
            }

            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked)) && ((checkBox3.Checked) || (checkBox4.Checked) || (checkBox5.Checked))      )
            {
                textBox1.Text = B1;
                textBox2.Text = B14;
            }
            
            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked)) && ((checkBox6.Checked)))
            {
                textBox1.Text = B1;
                textBox2.Text = B15;
            }

            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked)) && ((checkBox7.Checked)))
            {
                textBox1.Text = B1;
                textBox2.Text = B16;
            }

            if ((radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked) )
            {
                textBox1.Text = C1;
                textBox2.Text = C12;
            }

            if (   ((radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked)) &&  ((checkBox1.Checked) ||(checkBox2.Checked) ||(checkBox3.Checked)||(checkBox4.Checked) || (checkBox5.Checked))      )
            {
                textBox1.Text = C1;
                textBox2.Text = C13;
            }


            if (((radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked)) && ((checkBox6.Checked) || (checkBox7.Checked))     )
            {
                textBox1.Text = C1;
                textBox2.Text = C14;
            }


            if (((radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked)) && ((checkBox7.Checked)))
            {
                textBox1.Text = C1;
                textBox2.Text = C15;
            }



            //????????????????????????????????????????
             if (     ((radioButton8.Checked) || (radioButton9.Checked))  &&   ((checkBox8.Checked) && (checkBox9.Checked))      )
              {
                  textBox1.Text = C1;
                  textBox2.Text = C14;
              }


            if (((radioButton8.Checked) || (radioButton9.Checked) ) && ((checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked) || (checkBox4.Checked) || (checkBox5.Checked)) ) 
            {
                textBox1.Text = D1;
                textBox2.Text = D12;
            }

            if (    ((radioButton8.Checked) || (radioButton9.Checked)) && ((checkBox6.Checked))  )
            {
                textBox1.Text = D1;
                textBox2.Text = D13;
            }
            
            if (((radioButton8.Checked) || (radioButton9.Checked)) && ((checkBox7.Checked)))
            {
                textBox1.Text = D1;
                textBox2.Text = D14;
            }

            if (((radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked)) && ((checkBox8.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E12;
            }

            if (((radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked)) && ((checkBox9.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E13;
            }

            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked)) && ((checkBox8.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E14;
            }

            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked)) && ((checkBox9.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E15;
            }

            if (((radioButton8.Checked) || (radioButton9.Checked) ) && ((checkBox8.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E16;
            }

            if (((radioButton8.Checked) || (radioButton9.Checked)) && ((checkBox9.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E17;
            }

            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked) || (radioButton8.Checked) || (radioButton9.Checked)) && ((checkBox3.Checked)|| (checkBox4.Checked)||(checkBox5.Checked)) && ((checkBox8.Checked)) )
            {
                textBox1.Text = E1;
                textBox2.Text = E18;
            }

            if (((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked) || (radioButton8.Checked) || (radioButton9.Checked)) && ((checkBox3.Checked) || (checkBox4.Checked) || (checkBox5.Checked)) && ((checkBox6.Checked))  && ((checkBox8.Checked)))
            {
                textBox1.Text = E1;
                textBox2.Text = E19;
            }
            /////////????????????????????????????????????????????????????????????????????????
            if (checkBox10.Checked)
            {
                textBox1.Text = F1;
                textBox2.Text = F12;
            }

            if (((checkBox3.Checked) || (checkBox6.Checked)) && ((checkBox10.Checked)))
            {
                textBox1.Text = F1;
                textBox2.Text = F13;
            }

            if ((checkBox5.Checked) && (checkBox10.Checked))
            {
                textBox1.Text = F1;
                textBox2.Text = F14;
            }

            if ((checkBox4.Checked) && (checkBox10.Checked))
            {
                textBox1.Text = F1;
                textBox2.Text = F15;
            }


        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void calculation_Click(object sender, EventArgs e)
        {
            double total1_1;
            double total2_2;
            double total3_3;
            double total4_4;
            double expenses1;

            double cost1_1 = Convert.ToDouble(cost1.Text);
            double cost2_2 = Convert.ToDouble(cost2.Text);
            double cost3_3 = Convert.ToDouble(cost3.Text);
            double cost4_4 = Convert.ToDouble(cost4.Text);

            double quantity_PC = Convert.ToDouble(quantity_textBox1.Text);
            double quantity_server = Convert.ToDouble(quantity_textBox2.Text);
            double quantity_network = Convert.ToDouble(quantity_textBox3.Text);
            double quantity_fw = Convert.ToDouble(quantity_textBox4.Text);

            total1_1 = cost1_1 * quantity_PC;
            total2_2 = cost2_2 * quantity_server;
            total3_3 = cost3_3 * quantity_network;
            total4_4 = cost4_4 * quantity_fw;

            total1.Text = Convert.ToString(total1_1);
            total2.Text = Convert.ToString(total2_2);
            total3.Text = Convert.ToString(total3_3);
            total4.Text = Convert.ToString(total4_4);
            expenses1 = total1_1 + total2_2 + total3_3 + total4_4;
            expenses.Text = Convert.ToString(expenses1);
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            minute = 0;
            second = 0;
            minute2 = 0;
            second2 = 0;

            minute_label.Text = "00";
            second_label.Text = "00";


            timer1.Start();
            algorithm_label2.Text = "Уровень угрозы 1. Попробуйте проделать следующий алгоритм: \n";
            algorithm_label2.Text += "1)сделать что-то что-то 1 \n";
            algorithm_label2.Text += "2)сделать то  1 \n";
            algorithm_label2.Text += "3)сделать сё  1 \n";

            if (timer1.Enabled)
            {

                go_button.Enabled = true;
                stop_button.Enabled = true;
                algorithm_label2.Enabled = true;
                label18.Enabled = true;
            }
            Start_button.Enabled = false;
            


        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label3.Enabled = true;
            label20.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;

            label4.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;

            result_button.Enabled = true;
            timer1.Stop();
            
            label2.Visible = false;
            go_over_button.Visible = false;

        }

        //просто вывод времени
        private void timer3_Tick(object sender, EventArgs e)
        {
            date_time.Text = DateTime.Now.ToString();
        }





        private void go_button_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage5 /*needed tab*/;
            groupBox_PK.Enabled = true;
            groupBox_network.Enabled = true;
            groupBox_server.Enabled = true;
            groupBox_firewall.Enabled = true;

        }

        private void ready_Click(object sender, EventArgs e)
        {
            if (textBox_PK1.ForeColor == Color.ForestGreen
                && textBox_PK2.ForeColor == Color.ForestGreen && textBox_PK3.ForeColor == Color.ForestGreen
                && textBox_PK4.ForeColor == Color.ForestGreen && textBox_PK5.ForeColor == Color.ForestGreen
                && textBox_server1.ForeColor == Color.ForestGreen && textBox_server2.ForeColor == Color.ForestGreen
                && textBox_network1.ForeColor == Color.ForestGreen && textBox_network2.ForeColor == Color.ForestGreen
                && textBox_firewall1.ForeColor == Color.ForestGreen && textBox_firewall2.ForeColor == Color.ForestGreen
                )
            {
                active_textBox.Text = Convert.ToString(11);
                active_textBox2.Text = Convert.ToString(0);
                active = 11;
                this.tabControl1.SelectedTab = tabPage2 /*needed tab*/;
                label52.Visible = false;

            }
            else { label52.Visible = true; }


        }

        private void groupBox_PK_Enter(object sender, EventArgs e)
        {

        }

        private void button_PK1_Click(object sender, EventArgs e)
        {
            textBox_PK1.ForeColor = Color.ForestGreen;
            pk_textBox1.ForeColor = Color.ForestGreen;
        }


        private void button_PK2_Click(object sender, EventArgs e)
        {
            textBox_PK2.ForeColor = Color.ForestGreen;
            pk_textBox2.ForeColor = Color.ForestGreen;
        }

        private void button_PK3_Click(object sender, EventArgs e)
        {
            textBox_PK3.ForeColor = Color.ForestGreen;
            pk_textBox3.ForeColor = Color.ForestGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_PK4.ForeColor = Color.ForestGreen;
            pk_textBox4.ForeColor = Color.ForestGreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_PK5.ForeColor = Color.ForestGreen;
            pk_textBox5.ForeColor = Color.ForestGreen;
        }

        private void button_server1_Click(object sender, EventArgs e)
        {
            textBox_server1.ForeColor = Color.ForestGreen;
            server_textBox1.ForeColor = Color.ForestGreen;
        }

        private void button_server2_Click(object sender, EventArgs e)
        {
            textBox_server2.ForeColor = Color.ForestGreen;
            server_textBox2.ForeColor = Color.ForestGreen;
        }

        private void button_network1_Click(object sender, EventArgs e)
        {
            textBox_network1.ForeColor = Color.ForestGreen;
            network_devices_textBox1.ForeColor = Color.ForestGreen;
        }

        private void button_network2_Click(object sender, EventArgs e)
        {
            textBox_network2.ForeColor = Color.ForestGreen;
            network_devices_textBox2.ForeColor = Color.ForestGreen;
        }

        private void button_firewall1_Click(object sender, EventArgs e)
        {
            textBox_firewall1.ForeColor = Color.ForestGreen;
            firewall_textBox1.ForeColor = Color.ForestGreen;
        }

        private void button_firewall2_Click(object sender, EventArgs e)
        {
            textBox_firewall2.ForeColor = Color.ForestGreen;
            firewall_textBox2.ForeColor = Color.ForestGreen;
        }

        private void ez_game_Click(object sender, EventArgs e)
        {
            
            timer2.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
          
            label20.Enabled = false;
            label21.Enabled = false;
            label22.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;

            radioButton2.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;

            result_button.Enabled = false;
            algorithm_label2.Enabled = false;
            label18.Enabled = false;
            go_button.Enabled = false;
            stop_button.Enabled = false;
            label24.Enabled = false;
            label23.Enabled = false;
            second_label.Text = "00";
            minute_label.Text = "00";
            ez_game.Enabled = false;
            Start_button.Enabled = false;

            this.tabControl1.SelectedTab = tabPage1 /*needed tab*/;
        }




        //для ГРАФИКОВ 
        private void timer4_Tick(object sender, EventArgs e)
        {


            if (timer4.Enabled)
            {
                if (second3 < 59)
                {
                    second3++;
                    if (second3 == 30)
                    {
                        Random r = new Random();
                        //this.chart1.Series[0].Points.Clear(); //если пройдет 3 минуты (обновить)
                        string X = DateTime.Now.ToString("HH:mm:ss");
                        y1 = active;
                        y2 = r.Next(1, 8);

                        x1++;
                        x2++;
                        this.chart1.Series[0].Points.AddXY(X, y1);

                        this.chart2.Series[0].Points.AddXY(X, y2);
                    }
                }
                else
                {
                    minute3++;
                    second3 = 0;
                }


            }



        }

        // ТАЙМЕР ДЛЯ РЕШЕНИЯ ПРОБЛЕМА ( 2 ВКЛАДКА)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (second < 59)
                {
                    second++;
                    if (second < 10) { second_label.Text = "0" + second.ToString(); }
                    else { second_label.Text = second.ToString(); }
                }

                else
                {

                    minute++;
                    minute_label.Text = "0" + minute.ToString();
                    second = 0;
                    second_label.Text = "00";

                    if (minute == 1)
                    {

                        algorithm_label2.Text = "Вы не успели решить пролему за минуту. Угроза переходит на 2 уровень \n";
                        algorithm_label2.Text += "1)сделать что-то что-то \n";
                        algorithm_label2.Text += "2)сделать то \n";
                        algorithm_label2.Text += "3)сделать сё \n";

                    }

                    if (minute == 2)
                    {

                        algorithm_label2.Text = "Вы не успели решить пролему за 2 минуту. Угроза переходит на 3 уровень \n";
                        algorithm_label2.Text += "1) попробуй  \n";
                        algorithm_label2.Text += "2) давай  \n";
                        algorithm_label2.Text += "3) ну же \n";


                    }
                }


            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }



        private void go_over_button_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2 /*needed tab*/;
            Start_button.Enabled = true;


        }


        

        //ИЗМЕНЕНИЕ УЗЛОВ ( ТИПА СЛОМАЛИСЬ) 
        private void timer2_Tick(object sender, EventArgs e)
        {
            
                


            if (timer2.Enabled)
            {
                if (second2 < 59)
                {
                    second2++;
                    if (second2 == 30)
                    {
                        active = 0;
                        Random r = new Random();
                        //int kek = r.Next(2);
                        int[] kek = new int[11];
                        for (int i = 0; i < kek.Length; i++)
                        {
                            kek[i] = r.Next(2);

                        }

                        if (kek[0] == 1)
                        {
                            pk_textBox1.ForeColor = Color.Red;

                        }
                        else pk_textBox1.ForeColor = Color.ForestGreen;

                        if (kek[1] == 1)
                        {
                            pk_textBox2.ForeColor = Color.Red;

                        }
                        else pk_textBox2.ForeColor = Color.ForestGreen;
                        if (kek[2] == 1)
                        {
                            pk_textBox3.ForeColor = Color.Red;

                        }
                        else pk_textBox3.ForeColor = Color.ForestGreen;
                        if (kek[3] == 1)
                        {
                            pk_textBox4.ForeColor = Color.Red;

                        }
                        else pk_textBox4.ForeColor = Color.ForestGreen;
                        if (kek[4] == 1)
                        {
                            pk_textBox5.ForeColor = Color.Red;

                        }
                        else pk_textBox5.ForeColor = Color.ForestGreen;
                        if (kek[5] == 1)
                        {
                            server_textBox1.ForeColor = Color.Red;

                        }
                        else server_textBox1.ForeColor = Color.ForestGreen;

                        if (kek[6] == 1)
                        {
                            server_textBox2.ForeColor = Color.Red;

                        }
                        else server_textBox2.ForeColor = Color.ForestGreen;

                        if (kek[7] == 1)
                        {
                            network_devices_textBox1.ForeColor = Color.Red;

                        }
                        else network_devices_textBox1.ForeColor = Color.ForestGreen;
                        if (kek[8] == 1)
                        {
                            network_devices_textBox2.ForeColor = Color.Red;

                        }
                        else network_devices_textBox2.ForeColor = Color.ForestGreen;


                        if (kek[9] == 1)
                        {
                            firewall_textBox1.ForeColor = Color.Red;

                        }
                        else firewall_textBox1.ForeColor = Color.ForestGreen;

                        if (kek[10] == 1)
                        {
                            firewall_textBox2.ForeColor = Color.Red;

                        }
                        else firewall_textBox2.ForeColor = Color.ForestGreen;

                        if (pk_textBox1.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (pk_textBox2.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (pk_textBox3.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (pk_textBox4.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (pk_textBox5.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }



                        if (server_textBox1.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (server_textBox2.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (network_devices_textBox1.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (network_devices_textBox2.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        if (firewall_textBox1.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }

                        if (firewall_textBox2.ForeColor == Color.ForestGreen)
                        {
                            active++;
                        }
                        //ИЗМЕНЕНИЕ В ВКЛАДКЕ РЕШЕНИЕ
                        if (pk_textBox1.ForeColor == Color.Red) {
                            textBox_PK1.ForeColor = Color.Red;
                        }
                        if (pk_textBox2.ForeColor == Color.Red)
                        {
                            textBox_PK2.ForeColor = Color.Red;
                        }
                        if (pk_textBox3.ForeColor == Color.Red)
                        {
                            textBox_PK3.ForeColor = Color.Red;
                        }
                        if (pk_textBox4.ForeColor == Color.Red)
                        {
                            textBox_PK4.ForeColor = Color.Red;
                        }
                        if (pk_textBox5.ForeColor == Color.Red)
                        {
                            textBox_PK5.ForeColor = Color.Red;
                        }

                        if (server_textBox1.ForeColor == Color.Red)
                        {
                            textBox_server1.ForeColor = Color.Red;
                        }
                        if (server_textBox2.ForeColor == Color.Red)
                        { textBox_server2.ForeColor = Color.Red; }

                        if (network_devices_textBox1.ForeColor == Color.Red)
                            textBox_network1.ForeColor = Color.Red;
                        if (network_devices_textBox2.ForeColor == Color.Red)
                            textBox_network2.ForeColor = Color.Red;

                        if (firewall_textBox1.ForeColor == Color.Red)
                            textBox_firewall1.ForeColor = Color.Red;
                        if (firewall_textBox2.ForeColor == Color.Red)
                            textBox_firewall2.ForeColor = Color.Red;



                        active_textBox.Text = Convert.ToString(active);
                        active_textBox2.Text = Convert.ToString(11 - active);
                        label2.Visible = true;
                        go_over_button.Visible = true;
                        
                        
                        timer2.Enabled = false;







                    }
                }
                else
                {
                    minute2++;
                    second2 = 0;
                }
            }

            
        }
    }
}
