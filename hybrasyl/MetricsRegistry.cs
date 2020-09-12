﻿
/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2020 ERISCO, LLC 
 *
 * For contributors and individual authors please refer to CONTRIBUTORS.MD.
 * 
 */

using System;
using System.Collections.Generic;
using App.Metrics;
using App.Metrics.Meter;
using App.Metrics.Timer;

// THIS FILE IS AUTOGENERATED. CHANGES WILL NOT BE SAVED OR REFLECTED.
// Please look at the T4 template "metricsregistry.tt".

namespace Hybrasyl
{
    public static class HybrasylMetricsRegistry
    {

        public static Dictionary<int, TimerOptions> ControlMessageTimerIndex = new Dictionary<int, TimerOptions>()
    {
       {0, ControlMessageServiceTime_CleanupUser},
       {1, ControlMessageServiceTime_SaveUser},
       {2, ControlMessageServiceTime_ChaosRising},
       {3, ControlMessageServiceTime_ShutdownServer},
       {4, ControlMessageServiceTime_RegenUser},
       {5, ControlMessageServiceTime_LogoffUser},
       {6, ControlMessageServiceTime_MailNotifyUser},
       {7, ControlMessageServiceTime_StatusTick},
       {8, ControlMessageServiceTime_MonolithSpawn},
       {9, ControlMessageServiceTime_MonolithControl},
       {10, ControlMessageServiceTime_TriggerRefresh},
       {11, ControlMessageServiceTime_HandleDeath},
       {12, ControlMessageServiceTime_DialogRequest},
       {13, null},
       {14, null},
       {15, null},
       {16, null},
    };

    public static Dictionary<byte, TimerOptions> OpcodeTimerIndex = new Dictionary<byte, TimerOptions>()
    {
       {0, null},
       {1, null},
       {2, null},
       {3, null},
       {4, null},
       {5, OpcodeServiceTime_RequestMap},
       {6, OpcodeServiceTime_Walk},
       {7, OpcodeServiceTime_PickupItem},
       {8, OpcodeServiceTime_DropItem},
       {9, null},
       {10, null},
       {11, OpcodeServiceTime_ClientExit},
       {12, null},
       {13, null},
       {14, OpcodeServiceTime_Talk},
       {15, OpcodeServiceTime_UseSpell},
       {16, OpcodeServiceTime_ClientJoin},
       {17, OpcodeServiceTime_Turn},
       {18, null},
       {19, OpcodeServiceTime_Attack},
       {20, null},
       {21, null},
       {22, null},
       {23, null},
       {24, OpcodeServiceTime_ShowPlayerList},
       {25, OpcodeServiceTime_Whisper},
       {26, null},
       {27, OpcodeServiceTime_Settings},
       {28, OpcodeServiceTime_UseItem},
       {29, OpcodeServiceTime_Emote},
       {30, null},
       {31, null},
       {32, null},
       {33, null},
       {34, null},
       {35, null},
       {36, OpcodeServiceTime_DropGold},
       {37, null},
       {38, null},
       {39, null},
       {40, null},
       {41, OpcodeServiceTime_DropItemOnCreature},
       {42, OpcodeServiceTime_DropGoldOnCreature},
       {43, null},
       {44, null},
       {45, OpcodeServiceTime_PlayerInfo},
       {46, OpcodeServiceTime_GroupRequest},
       {47, OpcodeServiceTime_GroupToggle},
       {48, OpcodeServiceTime_MoveUIElement},
       {49, null},
       {50, null},
       {51, null},
       {52, null},
       {53, null},
       {54, null},
       {55, null},
       {56, OpcodeServiceTime_Refresh},
       {57, OpcodeServiceTime_NPCMainMenu},
       {58, OpcodeServiceTime_DialogUse},
       {59, OpcodeServiceTime_AccessMessages},
       {60, null},
       {61, null},
       {62, OpcodeServiceTime_UseSkill},
       {63, OpcodeServiceTime_MapPointClick},
       {64, null},
       {65, null},
       {66, null},
       {67, OpcodeServiceTime_PointClick},
       {68, OpcodeServiceTime_EquippedItemClick},
       {69, OpcodeServiceTime_ByteHeartbeat},
       {70, null},
       {71, OpcodeServiceTime_StatPoint},
       {72, null},
       {73, null},
       {74, OpcodeServiceTime_Trade},
       {75, null},
       {76, null},
       {77, OpcodeServiceTime_BeginCasting},
       {78, OpcodeServiceTime_CastLine},
       {79, OpcodeServiceTime_ProfileTextPortrait},
       {80, null},
       {81, null},
       {82, null},
       {83, null},
       {84, null},
       {85, null},
       {86, null},
       {87, null},
       {88, null},
       {89, null},
       {90, null},
       {91, null},
       {92, null},
       {93, null},
       {94, null},
       {95, null},
       {96, null},
       {97, null},
       {98, null},
       {99, null},
       {100, null},
       {101, null},
       {102, null},
       {103, null},
       {104, null},
       {105, null},
       {106, null},
       {107, null},
       {108, null},
       {109, null},
       {110, null},
       {111, null},
       {112, null},
       {113, null},
       {114, null},
       {115, null},
       {116, null},
       {117, OpcodeServiceTime_TickHeartbeat},
       {118, null},
       {119, null},
       {120, null},
       {121, OpcodeServiceTime_Status},
       {122, null},
       {123, OpcodeServiceTime_RequestMetafile},
       {124, null},
       {125, null},
       {126, null},
       {127, null},
       {128, null},
       {129, null},
       {130, null},
       {131, null},
       {132, null},
       {133, null},
       {134, null},
       {135, null},
       {136, null},
       {137, null},
       {138, null},
       {139, null},
       {140, null},
       {141, null},
       {142, null},
       {143, null},
       {144, null},
       {145, null},
       {146, null},
       {147, null},
       {148, null},
       {149, null},
       {150, null},
       {151, null},
       {152, null},
       {153, null},
       {154, null},
       {155, null},
       {156, null},
       {157, null},
       {158, null},
       {159, null},
       {160, null},
       {161, null},
       {162, null},
       {163, null},
       {164, null},
       {165, null},
       {166, null},
       {167, null},
       {168, null},
       {169, null},
       {170, null},
       {171, null},
       {172, null},
       {173, null},
       {174, null},
       {175, null},
       {176, null},
       {177, null},
       {178, null},
       {179, null},
       {180, null},
       {181, null},
       {182, null},
       {183, null},
       {184, null},
       {185, null},
       {186, null},
       {187, null},
       {188, null},
       {189, null},
       {190, null},
       {191, null},
       {192, null},
       {193, null},
       {194, null},
       {195, null},
       {196, null},
       {197, null},
       {198, null},
       {199, null},
       {200, null},
       {201, null},
       {202, null},
       {203, null},
       {204, null},
       {205, null},
       {206, null},
       {207, null},
       {208, null},
       {209, null},
       {210, null},
       {211, null},
       {212, null},
       {213, null},
       {214, null},
       {215, null},
       {216, null},
       {217, null},
       {218, null},
       {219, null},
       {220, null},
       {221, null},
       {222, null},
       {223, null},
       {224, null},
       {225, null},
       {226, null},
       {227, null},
       {228, null},
       {229, null},
       {230, null},
       {231, null},
       {232, null},
       {233, null},
       {234, null},
       {235, null},
       {236, null},
       {237, null},
       {238, null},
       {239, null},
       {240, null},
       {241, null},
       {242, null},
       {243, null},
       {244, null},
       {245, null},
       {246, null},
       {247, null},
       {248, null},
       {249, null},
       {250, null},
       {251, null},
       {252, null},
       {253, null},
       {254, null},
       {255, null},
    };

    public static MeterOptions ExceptionMeter => new MeterOptions
    {
        Name = "Exception Rate",
        MeasurementUnit = Unit.Errors
    };

    public static TimerOptions Opcode_RequestMap => new TimerOptions
    {
        Name = "RequestMap Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Walk => new TimerOptions
    {
        Name = "Walk Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_PickupItem => new TimerOptions
    {
        Name = "PickupItem Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_DropItem => new TimerOptions
    {
        Name = "DropItem Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_ClientExit => new TimerOptions
    {
        Name = "ClientExit Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Talk => new TimerOptions
    {
        Name = "Talk Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_UseSpell => new TimerOptions
    {
        Name = "UseSpell Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_ClientJoin => new TimerOptions
    {
        Name = "ClientJoin Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Turn => new TimerOptions
    {
        Name = "Turn Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Attack => new TimerOptions
    {
        Name = "Attack Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_ShowPlayerList => new TimerOptions
    {
        Name = "ShowPlayerList Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Whisper => new TimerOptions
    {
        Name = "Whisper Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Settings => new TimerOptions
    {
        Name = "Settings Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_UseItem => new TimerOptions
    {
        Name = "UseItem Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Emote => new TimerOptions
    {
        Name = "Emote Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_DropGold => new TimerOptions
    {
        Name = "DropGold Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_DropItemOnCreature => new TimerOptions
    {
        Name = "DropItemOnCreature Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_DropGoldOnCreature => new TimerOptions
    {
        Name = "DropGoldOnCreature Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_PlayerInfo => new TimerOptions
    {
        Name = "PlayerInfo Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_GroupRequest => new TimerOptions
    {
        Name = "GroupRequest Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_GroupToggle => new TimerOptions
    {
        Name = "GroupToggle Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_MoveUIElement => new TimerOptions
    {
        Name = "MoveUIElement Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Refresh => new TimerOptions
    {
        Name = "Refresh Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_NPCMainMenu => new TimerOptions
    {
        Name = "NPCMainMenu Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_DialogUse => new TimerOptions
    {
        Name = "DialogUse Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_AccessMessages => new TimerOptions
    {
        Name = "AccessMessages Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_UseSkill => new TimerOptions
    {
        Name = "UseSkill Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_MapPointClick => new TimerOptions
    {
        Name = "MapPointClick Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_PointClick => new TimerOptions
    {
        Name = "PointClick Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_EquippedItemClick => new TimerOptions
    {
        Name = "EquippedItemClick Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_ByteHeartbeat => new TimerOptions
    {
        Name = "ByteHeartbeat Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_StatPoint => new TimerOptions
    {
        Name = "StatPoint Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Trade => new TimerOptions
    {
        Name = "Trade Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_BeginCasting => new TimerOptions
    {
        Name = "BeginCasting Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_CastLine => new TimerOptions
    {
        Name = "CastLine Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_ProfileTextPortrait => new TimerOptions
    {
        Name = "ProfileTextPortrait Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_TickHeartbeat => new TimerOptions
    {
        Name = "TickHeartbeat Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_Status => new TimerOptions
    {
        Name = "Status Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };

    public static TimerOptions Opcode_RequestMetafile => new TimerOptions
    {
        Name = "RequestMetafile Packet Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };



    public static TimerOptions ControlMessage_CleanupUser => new TimerOptions
    {
        Name = "CleanupUser Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_SaveUser => new TimerOptions
    {
        Name = "SaveUser Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_ChaosRising => new TimerOptions
    {
        Name = "ChaosRising Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_ShutdownServer => new TimerOptions
    {
        Name = "ShutdownServer Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_RegenUser => new TimerOptions
    {
        Name = "RegenUser Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_LogoffUser => new TimerOptions
    {
        Name = "LogoffUser Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_MailNotifyUser => new TimerOptions
    {
        Name = "MailNotifyUser Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_StatusTick => new TimerOptions
    {
        Name = "StatusTick Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_MonolithSpawn => new TimerOptions
    {
        Name = "MonolithSpawn Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_MonolithControl => new TimerOptions
    {
        Name = "MonolithControl Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_TriggerRefresh => new TimerOptions
    {
        Name = "TriggerRefresh Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_HandleDeath => new TimerOptions
    {
        Name = "HandleDeath Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };


    public static TimerOptions ControlMessage_DialogRequest => new TimerOptions
    {
        Name = "DialogRequest Control Message Service Time",
        MeasurementUnit = Unit.Requests,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,
    };



    }
}
