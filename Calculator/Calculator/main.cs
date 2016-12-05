using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    enum State
    {
        STATE_NOTHING, //입력되지 않음
        STATE_LHS, //좌측 수 입력 완료
        STATE_OPERATOR, //좌측 수 & 연산자 입력 완료
    };

    enum Operator
    {
        OPERATOR_NOTHING, //입력되지 않음
        OPERATOR_ADD, // +
        OPERATOR_SUB, // -
        OPERATOR_MUL, // *
        OPERATOR_DIV  // /
    }

    public partial class form_main : Form
    {
        private int lhs = 0, rhs = 0;
        private State current_state = State.STATE_NOTHING;
        private Operator current_operator = Operator.OPERATOR_NOTHING;

        public form_main()
        {
            InitializeComponent();
        }

        private void button_equ_Click(object sender, EventArgs e)
        {
            // 입력된 lhs와 current_operator를 바탕으로 답 계산
            // lhs만 있는 경우 lhs 출력
            // 연산 완료 후 각 변수들 초기 상태로 되돌림
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            //창이 크기 조정에 대응하지 못하므로 사이즈 고정
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width, Height);
        }
    }
}
