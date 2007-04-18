//Copyright 2007 Guido Amarilla 
// http://code.google.com/p/ctr05lib/
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;
using MccDaq;

namespace CTR05Lib
{
    public class C9513Mode
    {
        private const int dataPort = 0x00;
        private const int cmdPort = 0x01;
        private const int cmdStatusRegister = 0x1F;
        private static readonly int[] cmdHoldRegister = { 0x11, 0x12, 0x13, 0x14, 0x15 };
        private static readonly int[] cmdModeRegister = { 0x01, 0x02, 0x03, 0x04, 0x05 };
        private static readonly int[] cmdLoadRegister = { 0x09, 0x0a, 0x0b, 0x0c, 0x0d };
        private static readonly MccDaq.CounterRegister[] _CounterRegister ={    MccDaq.CounterRegister.LoadReg1,
                                                                                                    MccDaq.CounterRegister.LoadReg2,
                                                                                                    MccDaq.CounterRegister.LoadReg3,
                                                                                                    MccDaq.CounterRegister.LoadReg4,
                                                                                                    MccDaq.CounterRegister.LoadReg5 };
        private static readonly int[] cmdClearOut = { 0xE1, 0xE2, 0xE3, 0xE4, 0xE5 };
        private static readonly int[] cmdSetOut = { 0xE9, 0xEA, 0xEB, 0xEC, 0xED };


        public C9513Mode()
        {
        }

        public ErrorInfo LoadModeO(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            myBoard.OutWord(cmdPort, (int)loadRegister + 9);
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(loadValue);
            myBoard.OutByte(dataPort, bytes[0]);
            myBoard.OutByte(dataPort, bytes[1]);
            return new ErrorInfo((int)ErrorInfo.ErrorCode.NoErrors);
        }

        public ErrorInfo LoadModeA(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            myBoard.OutWord(cmdPort, (int)loadRegister + 9);
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(loadValue);
            myBoard.OutByte(dataPort, bytes[0]);
            myBoard.OutByte(dataPort, bytes[1]);
            return new ErrorInfo((int)ErrorInfo.ErrorCode.NoErrors);
        }



        public ErrorInfo ModeOConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            myBoard.OutWord(cmdPort, cmdModeRegister[counterNum]);
            int specialGate = 1;
            int reloadSource = 0;
            int repitition = 0;
            int val = ((int)gateControl << 13) | ((int)counterEdge << 12) | ((int)counterSource << 8) | (specialGate << 7) | (reloadSource << 6) | (repitition << 5) | ((int)bcdMode << 4) | ((int)countDirection << 3) | (int)outputControl;
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(val);
            myBoard.OutByte(dataPort, bytes[0]);
            myBoard.OutByte(dataPort, bytes[1]);
            return new ErrorInfo((int)ErrorInfo.ErrorCode.NoErrors);
        }

        public ErrorInfo ModeAConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            myBoard.OutWord(cmdPort, cmdModeRegister[counterNum]);
            int specialGate = 0;
            int reloadSource = 0;
            int repitition = 0;
            int gateControl = 0;
            int val = ((int)gateControl << 13) | ((int)counterEdge << 12) | ((int)counterSource << 8) | (specialGate << 7) | (reloadSource << 6) | (repitition << 5) | ((int)bcdMode << 4) | ((int)countDirection << 3) | (int)outputControl;
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(val);
            myBoard.OutByte(dataPort, bytes[0]);
            myBoard.OutByte(dataPort, bytes[1]);
            return new ErrorInfo((int)ErrorInfo.ErrorCode.NoErrors);
        }

        public enum EdgeGate
        {
            AHEGate = 6,
            ALEGate = 7,
        }

        public enum LevelGate
        {
            AHLTcPrevCtr = 1,
            AHLNextGate = 2,
            AHLPrevGate = 3,
            AHLGate = 4,
            ALLGate = 5,
        }
    }
}
