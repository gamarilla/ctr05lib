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

using MccDaq;

namespace CTR05Lib
{

    public class C9513Mode
    {

        public enum EdgeGate
        {
            AHEGate = 6,
            ALEGate = 7
        }

        public enum LevelGate
        {
            AHLTcPrevCtr = 1,
            AHLNextGate = 2,
            AHLPrevGate = 3,
            AHLGate = 4,
            ALLGate = 5
        }

        public C9513Mode()
        {
        }

        public ErrorInfo LoadModeA(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeB(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeC(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeD(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeE(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeF(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeG(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeH(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeI(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeJ(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeK(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeL(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeN(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeO(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeQ(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeR(MccBoard myBoard, CounterRegister loadRegister, uint loadValue)
        {
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeS(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeV(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo LoadModeX(MccBoard myBoard, CounterRegister loadRegister, CounterRegister holdRegister, uint loadValue, uint holdValue)
        {
            myBoard.CLoad32(loadRegister, holdValue);
            return myBoard.CLoad32(loadRegister, loadValue);
        }

        public ErrorInfo ModeAConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            GateControl gateControl = GateControl.NoGate;
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeBConfig(MccBoard myBoard, int counterNum, C9513Mode.LevelGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeCConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeDConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            GateControl gateControl = GateControl.NoGate;
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeEConfig(MccBoard myBoard, int counterNum, C9513Mode.LevelGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeFConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeGConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            GateControl gateControl = GateControl.NoGate;
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeHConfig(MccBoard myBoard, int counterNum, C9513Mode.LevelGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeIConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeJConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            GateControl gateControl = GateControl.NoGate;
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeKConfig(MccBoard myBoard, int counterNum, C9513Mode.LevelGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeLConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Disabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeNConfig(MccBoard myBoard, int counterNum, C9513Mode.LevelGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeOConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeQConfig(MccBoard myBoard, int counterNum, C9513Mode.LevelGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeRConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeSConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            GateControl gateControl = GateControl.NoGate;
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.OneTime;
            return myBoard.C9513Config(counterNum, gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeVConfig(MccBoard myBoard, int counterNum, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            GateControl gateControl = GateControl.NoGate;
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

        public ErrorInfo ModeXConfig(MccBoard myBoard, int counterNum, C9513Mode.EdgeGate gateControl, CountEdge counterEdge, CounterSource counterSource, BCDMode bcdMode, CountDirection countDirection, C9513OutputControl outputControl)
        {
            OptionState optionState = OptionState.Enabled;
            Reload reload = Reload.LoadAndHoldReg;
            RecycleMode recycleMode = RecycleMode.Recycle;
            return myBoard.C9513Config(counterNum, (GateControl)gateControl, counterEdge, counterSource, optionState, reload, recycleMode, bcdMode, countDirection, outputControl);
        }

    } 

}
