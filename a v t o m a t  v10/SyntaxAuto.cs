using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_v_t_o_m_a_t__v10
{
    enum States { s, e, f, t1, t2, a1, a2, a3, a4, b, i1, i11, i2, c1, c11, c12, c121, c131, c13, c2, c21, k1, k11, k12, k13, k2, k21, k22, k23, k3, k31, k32, k33, k34, k35, k4, k41, k42, k43, k44, k45, k5, k51, k52, k53, k54, k55, k56, k6, k61, k62, k63, k7, k71, k72, k73, k74, d0, d1, d2, d3, d22, d222, de, df, e1, e12, e13, e2, e21, e3, e31, e32, e33, e4, e41, e42, e43, e5, e51, e52, e53, e6, e61, e62, e63, e7, e71, e72, e73, e74, e75, e8, e81, e82, e83, e84, e85, e86, e87, e88, e89, e810, e9, e91, e92, e93, e94, e95, e96 };
    class SyntaxAuto
    {
        private int curPos, erPos;
        private States st;
        private string str;
        
        public SyntaxAuto(string str)
        {
            this.str = (String)str.Clone();
        }

        public void Exec()
        {
            st = States.s;
            curPos = 0;
            char ch;
            while ((st != States.e)||(st != States.f)||(curPos <= this.str.Length)){
                ch = str[curPos];
                switch (st)
                {
                    case States.s:
                        ch = str[curPos];
                        if (ch == ' ') {
                            st = States.s;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'v')
                        {
                            st = States.a1;
                            curPos += 1;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.a1:
                        if (ch == 'v')
                        {
                            st = States.a2;
                            curPos += 1;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.a2:
                        if (ch == 'a')
                        {
                            st = States.a3;
                            curPos += 1;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.a3:
                        if (ch == 'r')
                        {
                            st = States.a3;
                            curPos += 1;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.a4:
                        if (ch == ' ')
                        {
                            st = States.a4;
                            curPos += 1;
                            break;
                        }
                        if (((ch > 'a') && (ch < 'z')) || ((ch > 'A') && (ch < 'Z')) || (ch == '_'))
                        {
                            st = States.i1;
                            curPos += 1;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.i1:
                        if (ch == ' ')
                        {
                            st = States.i11;
                            curPos += 1;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i1;
                            curPos += 1;
                            break;
                        }
                        if (ch == ':') { st = States.b;
                            curPos += 1;
                            break; }
                        if (ch == ' ')
                        {
                            st = States.i11;
                            curPos += 1;
                            break;
                        }
                        break;
                    case States.b:
                        if (ch == ' ') { st = States.b;
                            curPos += 1;
                            break; }
                        if (ch == 'f') {
                            st = States.c1;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'o')
                        {
                            st = States.e2;
                            curPos += 1;
                            break;
                        }
                        if (ch == 't')
                        {
                            st = States.e3;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'c')
                        {
                            st = States.e4;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'v')
                        {
                            st = States.e1;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'b')
                        {
                            st = States.e5;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'r')
                        {
                            st = States.e6;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'd')
                        {
                            st = States.e7;
                            curPos += 1;
                            break;
                        }
                        if (ch == 's')
                        {
                            st = States.e8;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'i')
                        {
                            st = States.e9;
                            curPos += 1;
                            break;
                        }
                        if (((ch > 'a') && (ch < 'z')) || ((ch > 'A') && (ch < 'Z')) || (ch == '_'))
                        {
                            st = States.i2;
                            curPos += 1;
                            break;
                        }
                            break;
                    case States.i11:
                        if (ch == ' ') {
                            st = States.i11;
                            curPos += 1;
                            break;
                        }
                        if (ch == ':') {
                            st = States.b;
                            curPos += 1;
                            break;
                        }
                        break;
                    case States.c1:
                        if (ch == 'i')
                        {
                            st = States.c11;
                            curPos += 1;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            curPos += 1;
                            st = States.i2;
                            break;
                        }
                        else st = States.e;
                           break;
                    case States.c11:
                        if (ch == 'l')
                        {
                            st = States.c11;
                            curPos += 1;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            curPos += 1;
                            st = States.i2;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.c12:
                        if (ch == 'e')
                        {
                            st = States.c121;
                            curPos += 1;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            curPos += 1;
                            st = States.i2;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.c121:
                        if (ch == ' ')
                        {
                            st = States.c13;
                            curPos += 1;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            curPos += 1;
                            st = States.i2;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.c13:
                        if (ch == ' ')
                        {
                            st = States.c13;
                            curPos += 1;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.f;
                            curPos += 1;
                            break;
                        }
                        if (ch == 'o')
                        {
                            st = States.c2;
                            curPos += 1;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.c2:
                        if (ch == 'f')
                        {
                            curPos += 1;
                            st = States.c21;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.c21:
                        if (ch == 'c')
                        {
                            st = States.k1;
                            curPos++;
                            break;
                        }
                        if (ch == 'b')
                        {
                            st = States.k2;
                            curPos++;
                            break;
                        }
                        if (ch == 'd')
                        {
                            st = States.k3;
                            curPos++;
                            break;
                        }
                        if (ch == 's')
                        {
                            st = States.k4;
                            curPos++;
                            break;
                        }
                        if (ch == 'i')
                        {
                            st = States.k5;
                            curPos++;
                            break;
                        }
                        if (ch == 'r')
                        {
                            st = States.k6;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k1:
                        if (ch == 'v')
                        {
                            st = States.k11;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k11:
                        if (ch == 'a')
                        {
                            st = States.k11;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k12:
                        if (ch == 'r')
                        {
                            st = States.k11;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k13:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k2:
                        if (ch == 'y')
                        {
                            st = States.k21;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k21:
                        if (ch == 't')
                        {
                            st = States.k22;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k22:
                        if (ch == 'e')
                        {
                            st = States.k23;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k23:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k3:
                        if (ch == 'o')
                        {
                            st = States.k31;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k31:
                        if (ch == 'u')
                        {
                            st = States.k32;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k32:
                        if (ch == 'b')
                        {
                            st = States.k33;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k33:
                        if (ch == 'l')
                        {
                            st = States.k34;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k34:
                        if (ch == 'e')
                        {
                            st = States.k35;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k35:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k4:
                        if (ch == 'i')
                        {
                            st = States.k41;
                            curPos++;
                            break;
                        }
                        if (ch == 't')
                        {
                            st = States.k7;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k41:
                        if (ch == 'n')
                        {
                            st = States.k42;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k42:
                        if (ch == 'g')
                        {
                            st = States.k43;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k43:
                        if (ch == 'l')
                        {
                            st = States.k44;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k44:
                        if (ch == 'e')
                        {
                            st = States.k45;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k45:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k5:
                        if (ch == 'n')
                        {
                            st = States.k51;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k51:
                        if (ch == 't')
                        {
                            st = States.k52;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k52:
                        if (ch == 'e')
                        {
                            st = States.k53;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k53:
                        if (ch == 'g')
                        {
                            st = States.k54;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k54:
                        if (ch == 'e')
                        {
                            st = States.k55;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k55:
                        if (ch == 'r')
                        {
                            st = States.k56;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k56:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k6:
                        if (ch == 'e')
                        {
                            st = States.k61;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k61:
                        if (ch == 'a')
                        {
                            st = States.k62;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k62:
                        if (ch == 'l')
                        {
                            st = States.k63;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k7:
                        if (ch == 'r')
                        {
                            st = States.k71;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k71:
                        if (ch == 'i')
                        {
                            st = States.k72;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k72:
                        if (ch == 'n')
                        {
                            st = States.k73;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k73:
                        if (ch == 'g')
                        {
                            st = States.k74;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.k74:
                        if (ch == '[')
                        {
                            st = States.d0;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.k74;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.d0:
                        if (ch == '1')
                        {
                            st = States.d1;
                            curPos++;
                            break;
                        }
                        if (ch == '2')
                        {
                            st = States.d2;
                            curPos++;
                            break;
                        }
                        if((ch >= '3') && (ch <= '9'))
                        {
                            st = States.d3;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.d1:
                        if ((ch >= '0') && (ch <= '9'))
                        {
                            st = States.d3;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.de;
                            curPos++;
                            break;
                        }
                        if (ch == ']')
                        {
                            st = States.df;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.d2:
                        if ((ch >= '0') && (ch <= '4'))
                        {
                            st = States.d3;
                            curPos++;
                            break;
                        }
                        if (ch == '5')
                        {
                            st = States.d22;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.de;
                            curPos++;
                            break;
                        }
                        if (ch == ']')
                        {
                            st = States.df;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.d22:
                        if ((ch >= '0') && (ch <= '5'))
                        {
                            st = States.d222;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.de;
                            curPos++;
                            break;
                        }
                        if (ch == ']')
                        {
                            st = States.df;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.d222:
                        if (ch == ' ')
                        {
                            st = States.de;
                            curPos++;
                            break;
                        }
                        if (ch == ']')
                        {
                            st = States.df;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.d3:
                        if (((ch >= '0') && (ch <= '9')) || (ch == ' '))
                        {
                            st = States.de;
                            curPos++;
                            break;
                        }
                        if (ch == ']')
                        {
                            st = States.df;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.de:
                        if (ch == ' ')
                        {
                            st = States.de;
                            curPos++;
                            break;
                        }
                        if (ch == ']')
                        {
                            st = States.df;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.df:
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e2:
                        if (ch == 'f')
                        {
                            st = States.e21;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e21:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                            {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e3:
                        if (ch == 'e')
                        {
                            st = States.e31;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e31:
                        if (ch == 'x')
                        {
                            st = States.e32;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e32:
                        if (ch == 't')
                        {
                            st = States.e33;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e33:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        } //<допустимое ключевое слово
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        } //<допустимое ключевое слово
                        else st = States.e;
                        break;
                    case States.e1:
                        if (ch == 'a')
                        {
                            st = States.e12;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e12:
                        if (ch == 'r')
                        {
                            st = States.e13;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e13:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e5:
                        if (ch == 'y')
                        {
                            st = States.e51;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e51:
                        if (ch == 't')
                        {
                            st = States.e52;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e52:
                        if (ch == 'e')
                        {
                            st = States.e53;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e53:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;//недопустимый символ
                        break;
                    case States.e6:
                        if (ch == 'e')
                        {
                            st = States.e61;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e61:
                        if (ch == 'a')
                        {
                            st = States.e62;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e62:
                        if (ch == 'l')
                        {
                            st = States.e63;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e63:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e7:
                        if (ch == 'o')
                        {
                            st = States.e71;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e71:
                        if (ch == 'u')
                        {
                            st = States.e72;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e72:
                        if (ch == 'b')
                        {
                            st = States.e73;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e73:
                        if (ch == 'l')
                        {
                            st = States.e74;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e74:
                        if (ch == 'e')
                        {
                            st = States.e75;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e75:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e8:
                        if (ch == 't')
                        {
                            st = States.e81;
                            curPos++;
                            break;
                        }
                        if (ch == 'i')
                        {
                            st = States.e86;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e81:
                        if (ch == 'r')
                        {
                            st = States.e82;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e82:
                        if (ch == 'i')
                        {
                            st = States.e83;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e83:
                        if (ch == 'n')
                        {
                            st = States.e84;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e84:
                        if (ch == 'g')
                        {
                            st = States.e85;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e85:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e86:
                        if (ch == 'n')
                        {
                            st = States.e87;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e87:
                        if (ch == 'g')
                        {
                            st = States.e88;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e88:
                        if (ch == 'l')
                        {
                            st = States.e89;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e89:
                        if (ch == 'e')
                        {
                            st = States.e810;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e810:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e9:
                        if (ch == 'n')
                        {
                            st = States.e91;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e91:
                        if (ch == 't')
                        {
                            st = States.e92;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e92:
                        if (ch == 'e')
                        {
                            st = States.e93;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e93:
                        if (ch == 'g')
                        {
                            st = States.e94;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e94:
                        if (ch == 'e')
                        {
                            st = States.e95;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e95:
                        if (ch == 'r')
                        {
                            st = States.e96;
                            curPos++;
                            break;
                        }
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e96:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.i2:
                        if (((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || (ch == '_') || ((ch >= '0') && (ch <= '9')))
                        {
                            st = States.i2;
                            curPos++;
                            break;
                        }
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.t1:
                        if (ch == ' ')
                        {
                            st = States.t1;
                            curPos++;
                            break;
                        }
                        if (ch == ';')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.t2:
                        if (ch == ' ')
                        {
                            st = States.t2;
                            curPos++;
                            break;
                        }
                        else st = States.e;
                        break;
                    case States.e:
                        throw new Exception();
                }
            }
        }
    }
}
