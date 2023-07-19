// This file is part of iRacingSDK.
//
// Copyright 2014 Dean Netherton
// https://github.com/vipoo/iRacingSDK.Net
//
// iRacingSDK is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// iRacingSDK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with iRacingSDK.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;

namespace iRacingSDK
{
    public partial class Telemetry : Dictionary<string, object>
    {
        public SessionData SessionData { get; set; }

        /// <summary>
        /// Seconds since session start
        /// </summary>
        public System.Double SessionTime
        {
            get { return (System.Double)this["SessionTime"]; }
        }

        /// <summary>
        /// Current update number
        /// </summary>
        public System.Int32 SessionTick
        {
            get { return (System.Int32)this["SessionTick"]; }
        }

        /// <summary>
        /// Session number
        /// </summary>
        public System.Int32 SessionNum
        {
            get { return (System.Int32)this["SessionNum"]; }
        }

        /// <summary>
        /// Session state
        /// </summary>
        public iRacingSDK.SessionState SessionState
        {
            get { return (iRacingSDK.SessionState)this["SessionState"]; }
        }

        /// <summary>
        /// Session ID
        /// </summary>
        public System.Int32 SessionUniqueID
        {
            get { return (System.Int32)this["SessionUniqueID"]; }
        }

        /// <summary>
        /// Session flags
        /// </summary>
        public iRacingSDK.SessionFlags SessionFlags
        {
            get { return (iRacingSDK.SessionFlags)this["SessionFlags"]; }
        }

        /// <summary>
        /// Seconds left till session ends
        /// </summary>
        public System.Double SessionTimeRemain
        {
            get { return (System.Double)this["SessionTimeRemain"]; }
        }

        /// <summary>
        /// Old laps left till session ends use SessionLapsRemainEx
        /// </summary>
        public System.Int32 SessionLapsRemain
        {
            get { return (System.Int32)this["SessionLapsRemain"]; }
        }

        /// <summary>
        /// New improved laps left till session ends
        /// </summary>
        public System.Int32 SessionLapsRemainEx
        {
            get { return (System.Int32)this["SessionLapsRemainEx"]; }
        }

        /// <summary>
        /// Total number of seconds in session
        /// </summary>
        public System.Double SessionTimeTotal
        {
            get { return (System.Double)this["SessionTimeTotal"]; }
        }

        /// <summary>
        /// Total number of laps in session
        /// </summary>
        public System.Int32 SessionLapsTotal
        {
            get { return (System.Int32)this["SessionLapsTotal"]; }
        }

        /// <summary>
        /// Joker laps remaining to be taken
        /// </summary>
        public System.Int32 SessionJokerLapsRemain
        {
            get { return (System.Int32)this["SessionJokerLapsRemain"]; }
        }

        /// <summary>
        /// Player is currently completing a joker lap
        /// </summary>
        public System.Boolean SessionOnJokerLap
        {
            get { return (System.Boolean)this["SessionOnJokerLap"]; }
        }

        /// <summary>
        /// Time of day in seconds
        /// </summary>
        public System.Single SessionTimeOfDay
        {
            get { return (System.Single)this["SessionTimeOfDay"]; }
        }

        /// <summary>
        /// The car index of the current person speaking on the radio
        /// </summary>
        public System.Int32 RadioTransmitCarIdx
        {
            get { return (System.Int32)this["RadioTransmitCarIdx"]; }
        }

        /// <summary>
        /// The radio index of the current person speaking on the radio
        /// </summary>
        public System.Int32 RadioTransmitRadioIdx
        {
            get { return (System.Int32)this["RadioTransmitRadioIdx"]; }
        }

        /// <summary>
        /// The frequency index of the current person speaking on the radio
        /// </summary>
        public System.Int32 RadioTransmitFrequencyIdx
        {
            get { return (System.Int32)this["RadioTransmitFrequencyIdx"]; }
        }

        /// <summary>
        /// Default units for the user interface 0 = english 1 = metric
        /// </summary>
        public iRacingSDK.DisplayUnits DisplayUnits
        {
            get { return (iRacingSDK.DisplayUnits)this["DisplayUnits"]; }
        }

        /// <summary>
        /// Driver activated flag
        /// </summary>
        public System.Boolean DriverMarker
        {
            get { return (System.Boolean)this["DriverMarker"]; }
        }

        /// <summary>
        /// Push to talk button state
        /// </summary>
        public System.Boolean PushToTalk
        {
            get { return (System.Boolean)this["PushToTalk"]; }
        }

        /// <summary>
        /// Push to pass button state
        /// </summary>
        public System.Boolean PushToPass
        {
            get { return (System.Boolean)this["PushToPass"]; }
        }

        /// <summary>
        /// Hybrid manual boost state
        /// </summary>
        public System.Boolean ManualBoost
        {
            get { return (System.Boolean)this["ManualBoost"]; }
        }

        /// <summary>
        /// Hybrid manual no boost state
        /// </summary>
        public System.Boolean ManualNoBoost
        {
            get { return (System.Boolean)this["ManualNoBoost"]; }
        }

        /// <summary>
        /// 1=Car on track physics running with player in car
        /// </summary>
        public System.Boolean IsOnTrack
        {
            get { return (System.Boolean)this["IsOnTrack"]; }
        }

        /// <summary>
        /// 0=replay not playing  1=replay playing
        /// </summary>
        public System.Boolean IsReplayPlaying
        {
            get { return (System.Boolean)this["IsReplayPlaying"]; }
        }

        /// <summary>
        /// Integer replay frame number (60 per second)
        /// </summary>
        public System.Int32 ReplayFrameNum
        {
            get { return (System.Int32)this["ReplayFrameNum"]; }
        }

        /// <summary>
        /// Integer replay frame number from end of tape
        /// </summary>
        public System.Int32 ReplayFrameNumEnd
        {
            get { return (System.Int32)this["ReplayFrameNumEnd"]; }
        }

        /// <summary>
        /// 0=disk based telemetry turned off  1=turned on
        /// </summary>
        public System.Boolean IsDiskLoggingEnabled
        {
            get { return (System.Boolean)this["IsDiskLoggingEnabled"]; }
        }

        /// <summary>
        /// 0=disk based telemetry file not being written  1=being written
        /// </summary>
        public System.Boolean IsDiskLoggingActive
        {
            get { return (System.Boolean)this["IsDiskLoggingActive"]; }
        }

        /// <summary>
        /// Average frames per second
        /// </summary>
        public System.Single FrameRate
        {
            get { return (System.Single)this["FrameRate"]; }
        }

        /// <summary>
        /// Percent of available tim fg thread took with a 1 sec avg
        /// </summary>
        public System.Single CpuUsageFG
        {
            get { return (System.Single)this["CpuUsageFG"]; }
        }

        /// <summary>
        /// Percent of available tim gpu took with a 1 sec avg
        /// </summary>
        public System.Single GpuUsage
        {
            get { return (System.Single)this["GpuUsage"]; }
        }

        /// <summary>
        /// Communications average latency
        /// </summary>
        public System.Single ChanAvgLatency
        {
            get { return (System.Single)this["ChanAvgLatency"]; }
        }

        /// <summary>
        /// Communications latency
        /// </summary>
        public System.Single ChanLatency
        {
            get { return (System.Single)this["ChanLatency"]; }
        }

        /// <summary>
        /// Communications quality
        /// </summary>
        public System.Single ChanQuality
        {
            get { return (System.Single)this["ChanQuality"]; }
        }

        /// <summary>
        /// Partner communications quality
        /// </summary>
        public System.Single ChanPartnerQuality
        {
            get { return (System.Single)this["ChanPartnerQuality"]; }
        }

        /// <summary>
        /// Percent of available tim bg thread took with a 1 sec avg
        /// </summary>
        public System.Single CpuUsageBG
        {
            get { return (System.Single)this["CpuUsageBG"]; }
        }

        /// <summary>
        /// Communications server clock skew
        /// </summary>
        public System.Single ChanClockSkew
        {
            get { return (System.Single)this["ChanClockSkew"]; }
        }

        /// <summary>
        /// Memory page faults per second
        /// </summary>
        public System.Single MemPageFaultSec
        {
            get { return (System.Single)this["MemPageFaultSec"]; }
        }

        /// <summary>
        /// Memory soft page faults per second
        /// </summary>
        public System.Single MemSoftPageFaultSec
        {
            get { return (System.Single)this["MemSoftPageFaultSec"]; }
        }

        /// <summary>
        /// Players position in race
        /// </summary>
        public System.Int32 PlayerCarPosition
        {
            get { return (System.Int32)this["PlayerCarPosition"]; }
        }

        /// <summary>
        /// Players class position in race
        /// </summary>
        public System.Int32 PlayerCarClassPosition
        {
            get { return (System.Int32)this["PlayerCarClassPosition"]; }
        }

        /// <summary>
        /// Player car class id
        /// </summary>
        public System.Int32 PlayerCarClass
        {
            get { return (System.Int32)this["PlayerCarClass"]; }
        }

        /// <summary>
        /// Players car track surface type
        /// </summary>
        public System.Int32 PlayerTrackSurface
        {
            get { return (System.Int32)this["PlayerTrackSurface"]; }
        }

        /// <summary>
        /// Players car track surface material type
        /// </summary>
        public System.Int32 PlayerTrackSurfaceMaterial
        {
            get { return (System.Int32)this["PlayerTrackSurfaceMaterial"]; }
        }

        /// <summary>
        /// Players carIdx
        /// </summary>
        public System.Int32 PlayerCarIdx
        {
            get { return (System.Int32)this["PlayerCarIdx"]; }
        }

        /// <summary>
        /// Players team incident count for this session
        /// </summary>
        public System.Int32 PlayerCarTeamIncidentCount
        {
            get { return (System.Int32)this["PlayerCarTeamIncidentCount"]; }
        }

        /// <summary>
        /// Players own incident count for this session
        /// </summary>
        public System.Int32 PlayerCarMyIncidentCount
        {
            get { return (System.Int32)this["PlayerCarMyIncidentCount"]; }
        }

        /// <summary>
        /// Teams current drivers incident count for this session
        /// </summary>
        public System.Int32 PlayerCarDriverIncidentCount
        {
            get { return (System.Int32)this["PlayerCarDriverIncidentCount"]; }
        }

        /// <summary>
        /// Players weight penalty
        /// </summary>
        public System.Single PlayerCarWeightPenalty
        {
            get { return (System.Single)this["PlayerCarWeightPenalty"]; }
        }

        /// <summary>
        /// Players power adjust
        /// </summary>
        public System.Single PlayerCarPowerAdjust
        {
            get { return (System.Single)this["PlayerCarPowerAdjust"]; }
        }

        /// <summary>
        /// Players dry tire set limit
        /// </summary>
        public System.Int32 PlayerCarDryTireSetLimit
        {
            get { return (System.Int32)this["PlayerCarDryTireSetLimit"]; }
        }

        /// <summary>
        /// Players car is being towed if time is greater than zero
        /// </summary>
        public System.Single PlayerCarTowTime
        {
            get { return (System.Single)this["PlayerCarTowTime"]; }
        }

        /// <summary>
        /// Players car is properly in there pitstall
        /// </summary>
        public System.Boolean PlayerCarInPitStall
        {
            get { return (System.Boolean)this["PlayerCarInPitStall"]; }
        }

        /// <summary>
        /// Players car pit service status bits
        /// </summary>
        public System.Int32 PlayerCarPitSvStatus
        {
            get { return (System.Int32)this["PlayerCarPitSvStatus"]; }
        }

        /// <summary>
        /// Players car current tire compound
        /// </summary>
        public System.Int32 PlayerTireCompound
        {
            get { return (System.Int32)this["PlayerTireCompound"]; }
        }

        /// <summary>
        /// Players car number of fast repairs used
        /// </summary>
        public System.Int32 PlayerFastRepairsUsed
        {
            get { return (System.Int32)this["PlayerFastRepairsUsed"]; }
        }

        /// <summary>
        /// Laps started by car index
        /// </summary>
        public System.Int32[] CarIdxLap
        {
            get { return (System.Int32[])this["CarIdxLap"]; }
        }

        /// <summary>
        /// Laps completed by car index
        /// </summary>
        public System.Int32[] CarIdxLapCompleted
        {
            get { return (System.Int32[])this["CarIdxLapCompleted"]; }
        }

        /// <summary>
        /// Percentage distance around lap by car index
        /// </summary>
        public System.Single[] CarIdxLapDistPct
        {
            get { return (System.Single[])this["CarIdxLapDistPct"]; }
        }

        /// <summary>
        /// Track surface type by car index
        /// </summary>
        public iRacingSDK.TrackLocation[] CarIdxTrackSurface
        {
            get { return (iRacingSDK.TrackLocation[])this["CarIdxTrackSurface"]; }
        }

        /// <summary>
        /// Track surface material type by car index
        /// </summary>
        public System.Int32[] CarIdxTrackSurfaceMaterial
        {
            get { return (System.Int32[])this["CarIdxTrackSurfaceMaterial"]; }
        }

        /// <summary>
        /// On pit road between the cones by car index
        /// </summary>
        public System.Boolean[] CarIdxOnPitRoad
        {
            get { return (System.Boolean[])this["CarIdxOnPitRoad"]; }
        }

        /// <summary>
        /// Cars position in race by car index
        /// </summary>
        public System.Int32[] CarIdxPosition
        {
            get { return (System.Int32[])this["CarIdxPosition"]; }
        }

        /// <summary>
        /// Cars class position in race by car index
        /// </summary>
        public System.Int32[] CarIdxClassPosition
        {
            get { return (System.Int32[])this["CarIdxClassPosition"]; }
        }

        /// <summary>
        /// Cars class id by car index
        /// </summary>
        public System.Int32[] CarIdxClass
        {
            get { return (System.Int32[])this["CarIdxClass"]; }
        }

        /// <summary>
        /// Race time behind leader or fastest lap time otherwise
        /// </summary>
        public System.Single[] CarIdxF2Time
        {
            get { return (System.Single[])this["CarIdxF2Time"]; }
        }

        /// <summary>
        /// Estimated time to reach current location on track
        /// </summary>
        public System.Single[] CarIdxEstTime
        {
            get { return (System.Single[])this["CarIdxEstTime"]; }
        }

        /// <summary>
        /// Cars last lap time
        /// </summary>
        public System.Single[] CarIdxLastLapTime
        {
            get { return (System.Single[])this["CarIdxLastLapTime"]; }
        }

        /// <summary>
        /// Cars best lap time
        /// </summary>
        public System.Single[] CarIdxBestLapTime
        {
            get { return (System.Single[])this["CarIdxBestLapTime"]; }
        }

        /// <summary>
        /// Cars best lap number
        /// </summary>
        public System.Int32[] CarIdxBestLapNum
        {
            get { return (System.Int32[])this["CarIdxBestLapNum"]; }
        }

        /// <summary>
        /// Cars current tire compound
        /// </summary>
        public System.Int32[] CarIdxTireCompound
        {
            get { return (System.Int32[])this["CarIdxTireCompound"]; }
        }

        /// <summary>
        /// Cars Qual tire compound
        /// </summary>
        public System.Int32[] CarIdxQualTireCompound
        {
            get { return (System.Int32[])this["CarIdxQualTireCompound"]; }
        }

        /// <summary>
        /// Cars Qual tire compound is locked-in
        /// </summary>
        public System.Boolean[] CarIdxQualTireCompoundLocked
        {
            get { return (System.Boolean[])this["CarIdxQualTireCompoundLocked"]; }
        }

        /// <summary>
        /// How many fast repairs each car has used
        /// </summary>
        public System.Int32[] CarIdxFastRepairsUsed
        {
            get { return (System.Int32[])this["CarIdxFastRepairsUsed"]; }
        }

        /// <summary>
        /// Session flags for each player
        /// </summary>
        public iRacingSDK.SessionFlags[] CarIdxSessionFlags
        {
            get { return (iRacingSDK.SessionFlags[])this["CarIdxSessionFlags"]; }
        }

        /// <summary>
        /// Are we pacing or not
        /// </summary>
        public System.Int32 PaceMode
        {
            get { return (System.Int32)this["PaceMode"]; }
        }

        /// <summary>
        /// What line cars are pacing in  or -1 if not pacing
        /// </summary>
        public System.Int32[] CarIdxPaceLine
        {
            get { return (System.Int32[])this["CarIdxPaceLine"]; }
        }

        /// <summary>
        /// What row cars are pacing in  or -1 if not pacing
        /// </summary>
        public System.Int32[] CarIdxPaceRow
        {
            get { return (System.Int32[])this["CarIdxPaceRow"]; }
        }

        /// <summary>
        /// Pacing status flags for each car
        /// </summary>
        public System.Int32[] CarIdxPaceFlags
        {
            get { return (System.Int32[])this["CarIdxPaceFlags"]; }
        }

        /// <summary>
        /// Is the player car on pit road between the cones
        /// </summary>
        public System.Boolean OnPitRoad
        {
            get { return (System.Boolean)this["OnPitRoad"]; }
        }

        /// <summary>
        /// Steering wheel angle by car index
        /// </summary>
        public System.Single[] CarIdxSteer
        {
            get { return (System.Single[])this["CarIdxSteer"]; }
        }

        /// <summary>
        /// Engine rpm by car index
        /// </summary>
        public System.Single[] CarIdxRPM
        {
            get { return (System.Single[])this["CarIdxRPM"]; }
        }

        /// <summary>
        /// -1=reverse  0=neutral  1..n=current gear by car index
        /// </summary>
        public System.Int32[] CarIdxGear
        {
            get { return (System.Int32[])this["CarIdxGear"]; }
        }

        /// <summary>
        /// Steering wheel angle
        /// </summary>
        public System.Single SteeringWheelAngle
        {
            get { return (System.Single)this["SteeringWheelAngle"]; }
        }

        /// <summary>
        /// 0=off throttle to 1=full throttle
        /// </summary>
        public System.Single Throttle
        {
            get { return (System.Single)this["Throttle"]; }
        }

        /// <summary>
        /// 0=brake released to 1=max pedal force
        /// </summary>
        public System.Single Brake
        {
            get { return (System.Single)this["Brake"]; }
        }

        /// <summary>
        /// 0=disengaged to 1=fully engaged
        /// </summary>
        public System.Single Clutch
        {
            get { return (System.Single)this["Clutch"]; }
        }

        /// <summary>
        /// -1=reverse  0=neutral  1..n=current gear
        /// </summary>
        public System.Int32 Gear
        {
            get { return (System.Int32)this["Gear"]; }
        }

        /// <summary>
        /// Engine rpm
        /// </summary>
        public System.Single RPM
        {
            get { return (System.Single)this["RPM"]; }
        }

        /// <summary>
        /// Laps started count
        /// </summary>
        public System.Int32 Lap
        {
            get { return (System.Int32)this["Lap"]; }
        }

        /// <summary>
        /// Laps completed count
        /// </summary>
        public System.Int32 LapCompleted
        {
            get { return (System.Int32)this["LapCompleted"]; }
        }

        /// <summary>
        /// Meters traveled from S/F this lap
        /// </summary>
        public System.Single LapDist
        {
            get { return (System.Single)this["LapDist"]; }
        }

        /// <summary>
        /// Percentage distance around lap
        /// </summary>
        public System.Single LapDistPct
        {
            get { return (System.Single)this["LapDistPct"]; }
        }

        /// <summary>
        /// Laps completed in race
        /// </summary>
        public System.Int32 RaceLaps
        {
            get { return (System.Int32)this["RaceLaps"]; }
        }

        /// <summary>
        /// Players best lap number
        /// </summary>
        public System.Int32 LapBestLap
        {
            get { return (System.Int32)this["LapBestLap"]; }
        }

        /// <summary>
        /// Players best lap time
        /// </summary>
        public System.Single LapBestLapTime
        {
            get { return (System.Single)this["LapBestLapTime"]; }
        }

        /// <summary>
        /// Players last lap time
        /// </summary>
        public System.Single LapLastLapTime
        {
            get { return (System.Single)this["LapLastLapTime"]; }
        }

        /// <summary>
        /// Estimate of players current lap time as shown in F3 box
        /// </summary>
        public System.Single LapCurrentLapTime
        {
            get { return (System.Single)this["LapCurrentLapTime"]; }
        }

        /// <summary>
        /// Player num consecutive clean laps completed for N average
        /// </summary>
        public System.Int32 LapLasNLapSeq
        {
            get { return (System.Int32)this["LapLasNLapSeq"]; }
        }

        /// <summary>
        /// Player last N average lap time
        /// </summary>
        public System.Single LapLastNLapTime
        {
            get { return (System.Single)this["LapLastNLapTime"]; }
        }

        /// <summary>
        /// Player last lap in best N average lap time
        /// </summary>
        public System.Int32 LapBestNLapLap
        {
            get { return (System.Int32)this["LapBestNLapLap"]; }
        }

        /// <summary>
        /// Player best N average lap time
        /// </summary>
        public System.Single LapBestNLapTime
        {
            get { return (System.Single)this["LapBestNLapTime"]; }
        }

        /// <summary>
        /// Delta time for best lap
        /// </summary>
        public System.Single LapDeltaToBestLap
        {
            get { return (System.Single)this["LapDeltaToBestLap"]; }
        }

        /// <summary>
        /// Rate of change of delta time for best lap
        /// </summary>
        public System.Single LapDeltaToBestLap_DD
        {
            get { return (System.Single)this["LapDeltaToBestLap_DD"]; }
        }

        /// <summary>
        /// Delta time for best lap is valid
        /// </summary>
        public System.Boolean LapDeltaToBestLap_OK
        {
            get { return (System.Boolean)this["LapDeltaToBestLap_OK"]; }
        }

        /// <summary>
        /// Delta time for optimal lap
        /// </summary>
        public System.Single LapDeltaToOptimalLap
        {
            get { return (System.Single)this["LapDeltaToOptimalLap"]; }
        }

        /// <summary>
        /// Rate of change of delta time for optimal lap
        /// </summary>
        public System.Single LapDeltaToOptimalLap_DD
        {
            get { return (System.Single)this["LapDeltaToOptimalLap_DD"]; }
        }

        /// <summary>
        /// Delta time for optimal lap is valid
        /// </summary>
        public System.Boolean LapDeltaToOptimalLap_OK
        {
            get { return (System.Boolean)this["LapDeltaToOptimalLap_OK"]; }
        }

        /// <summary>
        /// Delta time for session best lap
        /// </summary>
        public System.Single LapDeltaToSessionBestLap
        {
            get { return (System.Single)this["LapDeltaToSessionBestLap"]; }
        }

        /// <summary>
        /// Rate of change of delta time for session best lap
        /// </summary>
        public System.Single LapDeltaToSessionBestLap_DD
        {
            get { return (System.Single)this["LapDeltaToSessionBestLap_DD"]; }
        }

        /// <summary>
        /// Delta time for session best lap is valid
        /// </summary>
        public System.Boolean LapDeltaToSessionBestLap_OK
        {
            get { return (System.Boolean)this["LapDeltaToSessionBestLap_OK"]; }
        }

        /// <summary>
        /// Delta time for session optimal lap
        /// </summary>
        public System.Single LapDeltaToSessionOptimalLap
        {
            get { return (System.Single)this["LapDeltaToSessionOptimalLap"]; }
        }

        /// <summary>
        /// Rate of change of delta time for session optimal lap
        /// </summary>
        public System.Single LapDeltaToSessionOptimalLap_DD
        {
            get { return (System.Single)this["LapDeltaToSessionOptimalLap_DD"]; }
        }

        /// <summary>
        /// Delta time for session optimal lap is valid
        /// </summary>
        public System.Boolean LapDeltaToSessionOptimalLap_OK
        {
            get { return (System.Boolean)this["LapDeltaToSessionOptimalLap_OK"]; }
        }

        /// <summary>
        /// Delta time for session last lap
        /// </summary>
        public System.Single LapDeltaToSessionLastlLap
        {
            get { return (System.Single)this["LapDeltaToSessionLastlLap"]; }
        }

        /// <summary>
        /// Rate of change of delta time for session last lap
        /// </summary>
        public System.Single LapDeltaToSessionLastlLap_DD
        {
            get { return (System.Single)this["LapDeltaToSessionLastlLap_DD"]; }
        }

        /// <summary>
        /// Delta time for session last lap is valid
        /// </summary>
        public System.Boolean LapDeltaToSessionLastlLap_OK
        {
            get { return (System.Boolean)this["LapDeltaToSessionLastlLap_OK"]; }
        }

        /// <summary>
        /// GPS vehicle speed
        /// </summary>
        public System.Single Speed
        {
            get { return (System.Single)this["Speed"]; }
        }

        /// <summary>
        /// Yaw orientation
        /// </summary>
        public System.Single Yaw
        {
            get { return (System.Single)this["Yaw"]; }
        }

        /// <summary>
        /// Yaw orientation relative to north
        /// </summary>
        public System.Single YawNorth
        {
            get { return (System.Single)this["YawNorth"]; }
        }

        /// <summary>
        /// Pitch orientation
        /// </summary>
        public System.Single Pitch
        {
            get { return (System.Single)this["Pitch"]; }
        }

        /// <summary>
        /// Roll orientation
        /// </summary>
        public System.Single Roll
        {
            get { return (System.Single)this["Roll"]; }
        }

        /// <summary>
        /// Indicate action the reset key will take 0 enter 1 exit 2 reset
        /// </summary>
        public System.Int32 EnterExitReset
        {
            get { return (System.Int32)this["EnterExitReset"]; }
        }

        /// <summary>
        /// Deprecated  set to TrackTempCrew
        /// </summary>
        public System.Single TrackTemp
        {
            get { return (System.Single)this["TrackTemp"]; }
        }

        /// <summary>
        /// Temperature of track measured by crew around track
        /// </summary>
        public System.Single TrackTempCrew
        {
            get { return (System.Single)this["TrackTempCrew"]; }
        }

        /// <summary>
        /// Temperature of air at start/finish line
        /// </summary>
        public System.Single AirTemp
        {
            get { return (System.Single)this["AirTemp"]; }
        }

        /// <summary>
        /// Weather type (0=constant  1=dynamic)
        /// </summary>
        public iRacingSDK.WeatherType WeatherType
        {
            get { return (iRacingSDK.WeatherType)this["WeatherType"]; }
        }

        /// <summary>
        /// Skies (0=clear/1=p cloudy/2=m cloudy/3=overcast)
        /// </summary>
        public iRacingSDK.Skies Skies
        {
            get { return (iRacingSDK.Skies)this["Skies"]; }
        }

        /// <summary>
        /// Density of air at start/finish line
        /// </summary>
        public System.Single AirDensity
        {
            get { return (System.Single)this["AirDensity"]; }
        }

        /// <summary>
        /// Pressure of air at start/finish line
        /// </summary>
        public System.Single AirPressure
        {
            get { return (System.Single)this["AirPressure"]; }
        }

        /// <summary>
        /// Wind velocity at start/finish line
        /// </summary>
        public System.Single WindVel
        {
            get { return (System.Single)this["WindVel"]; }
        }

        /// <summary>
        /// Wind direction at start/finish line
        /// </summary>
        public System.Single WindDir
        {
            get { return (System.Single)this["WindDir"]; }
        }

        /// <summary>
        /// Relative Humidity
        /// </summary>
        public System.Single RelativeHumidity
        {
            get { return (System.Single)this["RelativeHumidity"]; }
        }

        /// <summary>
        /// Fog level
        /// </summary>
        public System.Single FogLevel
        {
            get { return (System.Single)this["FogLevel"]; }
        }

        /// <summary>
        /// Sun angle above horizon in radians
        /// </summary>
        public System.Single SolarAltitude
        {
            get { return (System.Single)this["SolarAltitude"]; }
        }

        /// <summary>
        /// Sun angle clockwise from north in radians
        /// </summary>
        public System.Single SolarAzimuth
        {
            get { return (System.Single)this["SolarAzimuth"]; }
        }

        /// <summary>
        /// Status of driver change lap requirements
        /// </summary>
        public System.Int32 DCLapStatus
        {
            get { return (System.Int32)this["DCLapStatus"]; }
        }

        /// <summary>
        /// Number of team drivers who have run a stint
        /// </summary>
        public System.Int32 DCDriversSoFar
        {
            get { return (System.Int32)this["DCDriversSoFar"]; }
        }

        /// <summary>
        /// True if it is ok to reload car textures at this time
        /// </summary>
        public System.Boolean OkToReloadTextures
        {
            get { return (System.Boolean)this["OkToReloadTextures"]; }
        }

        /// <summary>
        /// True if the car_num texture will be loaded
        /// </summary>
        public System.Boolean LoadNumTextures
        {
            get { return (System.Boolean)this["LoadNumTextures"]; }
        }

        /// <summary>
        /// Notify if car is to the left or right of driver
        /// </summary>
        public System.Int32 CarLeftRight
        {
            get { return (System.Int32)this["CarLeftRight"]; }
        }

        /// <summary>
        /// True if pit stop is allowed for the current player
        /// </summary>
        public System.Boolean PitsOpen
        {
            get { return (System.Boolean)this["PitsOpen"]; }
        }

        /// <summary>
        /// True if video capture system is enabled
        /// </summary>
        public System.Boolean VidCapEnabled
        {
            get { return (System.Boolean)this["VidCapEnabled"]; }
        }

        /// <summary>
        /// True if video currently being captured
        /// </summary>
        public System.Boolean VidCapActive
        {
            get { return (System.Boolean)this["VidCapActive"]; }
        }

        /// <summary>
        /// Time left for mandatory pit repairs if repairs are active
        /// </summary>
        public System.Single PitRepairLeft
        {
            get { return (System.Single)this["PitRepairLeft"]; }
        }

        /// <summary>
        /// Time left for optional repairs if repairs are active
        /// </summary>
        public System.Single PitOptRepairLeft
        {
            get { return (System.Single)this["PitOptRepairLeft"]; }
        }

        /// <summary>
        /// Is the player getting pit stop service
        /// </summary>
        public System.Boolean PitstopActive
        {
            get { return (System.Boolean)this["PitstopActive"]; }
        }

        /// <summary>
        /// How many fast repairs used so far
        /// </summary>
        public System.Int32 FastRepairUsed
        {
            get { return (System.Int32)this["FastRepairUsed"]; }
        }

        /// <summary>
        /// How many fast repairs left  255 is unlimited
        /// </summary>
        public System.Int32 FastRepairAvailable
        {
            get { return (System.Int32)this["FastRepairAvailable"]; }
        }

        /// <summary>
        /// How many left front tires used so far
        /// </summary>
        public System.Int32 LFTiresUsed
        {
            get { return (System.Int32)this["LFTiresUsed"]; }
        }

        /// <summary>
        /// How many right front tires used so far
        /// </summary>
        public System.Int32 RFTiresUsed
        {
            get { return (System.Int32)this["RFTiresUsed"]; }
        }

        /// <summary>
        /// How many left rear tires used so far
        /// </summary>
        public System.Int32 LRTiresUsed
        {
            get { return (System.Int32)this["LRTiresUsed"]; }
        }

        /// <summary>
        /// How many right rear tires used so far
        /// </summary>
        public System.Int32 RRTiresUsed
        {
            get { return (System.Int32)this["RRTiresUsed"]; }
        }

        /// <summary>
        /// How many left tire sets used so far
        /// </summary>
        public System.Int32 LeftTireSetsUsed
        {
            get { return (System.Int32)this["LeftTireSetsUsed"]; }
        }

        /// <summary>
        /// How many right tire sets used so far
        /// </summary>
        public System.Int32 RightTireSetsUsed
        {
            get { return (System.Int32)this["RightTireSetsUsed"]; }
        }

        /// <summary>
        /// How many front tire sets used so far
        /// </summary>
        public System.Int32 FrontTireSetsUsed
        {
            get { return (System.Int32)this["FrontTireSetsUsed"]; }
        }

        /// <summary>
        /// How many rear tire sets used so far
        /// </summary>
        public System.Int32 RearTireSetsUsed
        {
            get { return (System.Int32)this["RearTireSetsUsed"]; }
        }

        /// <summary>
        /// How many tire sets used so far
        /// </summary>
        public System.Int32 TireSetsUsed
        {
            get { return (System.Int32)this["TireSetsUsed"]; }
        }

        /// <summary>
        /// How many left front tires are remaining  255 is unlimited
        /// </summary>
        public System.Int32 LFTiresAvailable
        {
            get { return (System.Int32)this["LFTiresAvailable"]; }
        }

        /// <summary>
        /// How many right front tires are remaining  255 is unlimited
        /// </summary>
        public System.Int32 RFTiresAvailable
        {
            get { return (System.Int32)this["RFTiresAvailable"]; }
        }

        /// <summary>
        /// How many left rear tires are remaining  255 is unlimited
        /// </summary>
        public System.Int32 LRTiresAvailable
        {
            get { return (System.Int32)this["LRTiresAvailable"]; }
        }

        /// <summary>
        /// How many right rear tires are remaining  255 is unlimited
        /// </summary>
        public System.Int32 RRTiresAvailable
        {
            get { return (System.Int32)this["RRTiresAvailable"]; }
        }

        /// <summary>
        /// How many left tire sets are remaining  255 is unlimited
        /// </summary>
        public System.Int32 LeftTireSetsAvailable
        {
            get { return (System.Int32)this["LeftTireSetsAvailable"]; }
        }

        /// <summary>
        /// How many right tire sets are remaining  255 is unlimited
        /// </summary>
        public System.Int32 RightTireSetsAvailable
        {
            get { return (System.Int32)this["RightTireSetsAvailable"]; }
        }

        /// <summary>
        /// How many front tire sets are remaining  255 is unlimited
        /// </summary>
        public System.Int32 FrontTireSetsAvailable
        {
            get { return (System.Int32)this["FrontTireSetsAvailable"]; }
        }

        /// <summary>
        /// How many rear tire sets are remaining  255 is unlimited
        /// </summary>
        public System.Int32 RearTireSetsAvailable
        {
            get { return (System.Int32)this["RearTireSetsAvailable"]; }
        }

        /// <summary>
        /// How many tire sets are remaining  255 is unlimited
        /// </summary>
        public System.Int32 TireSetsAvailable
        {
            get { return (System.Int32)this["TireSetsAvailable"]; }
        }

        /// <summary>
        /// Active camera's focus car index
        /// </summary>
        public System.Int32 CamCarIdx
        {
            get { return (System.Int32)this["CamCarIdx"]; }
        }

        /// <summary>
        /// Active camera number
        /// </summary>
        public System.Int32 CamCameraNumber
        {
            get { return (System.Int32)this["CamCameraNumber"]; }
        }

        /// <summary>
        /// Active camera group number
        /// </summary>
        public System.Int32 CamGroupNumber
        {
            get { return (System.Int32)this["CamGroupNumber"]; }
        }

        /// <summary>
        /// State of camera system
        /// </summary>
        public System.Int32 CamCameraState
        {
            get { return (System.Int32)this["CamCameraState"]; }
        }

        /// <summary>
        /// 1=Car on track physics running
        /// </summary>
        public System.Boolean IsOnTrackCar
        {
            get { return (System.Boolean)this["IsOnTrackCar"]; }
        }

        /// <summary>
        /// 1=Car in garage physics running
        /// </summary>
        public System.Boolean IsInGarage
        {
            get { return (System.Boolean)this["IsInGarage"]; }
        }

        /// <summary>
        /// Steering wheel max angle
        /// </summary>
        public System.Single SteeringWheelAngleMax
        {
            get { return (System.Single)this["SteeringWheelAngleMax"]; }
        }

        /// <summary>
        /// Friction torque applied to gears when shifting or grinding
        /// </summary>
        public System.Single ShiftPowerPct
        {
            get { return (System.Single)this["ShiftPowerPct"]; }
        }

        /// <summary>
        /// RPM of shifter grinding noise
        /// </summary>
        public System.Single ShiftGrindRPM
        {
            get { return (System.Single)this["ShiftGrindRPM"]; }
        }

        /// <summary>
        /// Raw throttle input 0=off throttle to 1=full throttle
        /// </summary>
        public System.Single ThrottleRaw
        {
            get { return (System.Single)this["ThrottleRaw"]; }
        }

        /// <summary>
        /// Raw brake input 0=brake released to 1=max pedal force
        /// </summary>
        public System.Single BrakeRaw
        {
            get { return (System.Single)this["BrakeRaw"]; }
        }

        /// <summary>
        /// Raw clutch input 0=disengaged to 1=fully engaged
        /// </summary>
        public System.Single ClutchRaw
        {
            get { return (System.Single)this["ClutchRaw"]; }
        }

        /// <summary>
        /// Raw handbrake input 0=handbrake released to 1=max force
        /// </summary>
        public System.Single HandbrakeRaw
        {
            get { return (System.Single)this["HandbrakeRaw"]; }
        }

        /// <summary>
        /// true if abs is currently reducing brake force pressure
        /// </summary>
        public System.Boolean BrakeABSactive
        {
            get { return (System.Boolean)this["BrakeABSactive"]; }
        }

        /// <summary>
        /// Bitfield for warning lights
        /// </summary>
        public iRacingSDK.EngineWarnings EngineWarnings
        {
            get { return (iRacingSDK.EngineWarnings)this["EngineWarnings"]; }
        }

        /// <summary>
        /// Percent fuel remaining
        /// </summary>
        public System.Single FuelLevelPct
        {
            get { return (System.Single)this["FuelLevelPct"]; }
        }

        /// <summary>
        /// Bitfield of pit service checkboxes
        /// </summary>
        public System.Int32 PitSvFlags
        {
            get { return (System.Int32)this["PitSvFlags"]; }
        }

        /// <summary>
        /// Pit service left front tire pressure
        /// </summary>
        public System.Single PitSvLFP
        {
            get { return (System.Single)this["PitSvLFP"]; }
        }

        /// <summary>
        /// Pit service right front tire pressure
        /// </summary>
        public System.Single PitSvRFP
        {
            get { return (System.Single)this["PitSvRFP"]; }
        }

        /// <summary>
        /// Pit service left rear tire pressure
        /// </summary>
        public System.Single PitSvLRP
        {
            get { return (System.Single)this["PitSvLRP"]; }
        }

        /// <summary>
        /// Pit service right rear tire pressure
        /// </summary>
        public System.Single PitSvRRP
        {
            get { return (System.Single)this["PitSvRRP"]; }
        }

        /// <summary>
        /// Pit service fuel add amount
        /// </summary>
        public System.Single PitSvFuel
        {
            get { return (System.Single)this["PitSvFuel"]; }
        }

        /// <summary>
        /// Pit service pending tire compound
        /// </summary>
        public System.Int32 PitSvTireCompound
        {
            get { return (System.Int32)this["PitSvTireCompound"]; }
        }

        /// <summary>
        /// Push2Pass active or not
        /// </summary>
        public System.Boolean[] CarIdxP2P_Status
        {
            get { return (System.Boolean[])this["CarIdxP2P_Status"]; }
        }

        /// <summary>
        /// Push2Pass count of usage (or remaining in Race)
        /// </summary>
        public System.Int32[] CarIdxP2P_Count
        {
            get { return (System.Int32[])this["CarIdxP2P_Count"]; }
        }

        /// <summary>
        /// Force feedback % max torque on steering shaft unsigned
        /// </summary>
        public System.Single SteeringWheelPctTorque
        {
            get { return (System.Single)this["SteeringWheelPctTorque"]; }
        }

        /// <summary>
        /// Force feedback % max torque on steering shaft signed
        /// </summary>
        public System.Single SteeringWheelPctTorqueSign
        {
            get { return (System.Single)this["SteeringWheelPctTorqueSign"]; }
        }

        /// <summary>
        /// Force feedback % max torque on steering shaft signed stops
        /// </summary>
        public System.Single SteeringWheelPctTorqueSignStops
        {
            get { return (System.Single)this["SteeringWheelPctTorqueSignStops"]; }
        }

        /// <summary>
        /// Force feedback % max smoothing
        /// </summary>
        public System.Single SteeringWheelPctSmoothing
        {
            get { return (System.Single)this["SteeringWheelPctSmoothing"]; }
        }

        /// <summary>
        /// Force feedback % max damping
        /// </summary>
        public System.Single SteeringWheelPctDamper
        {
            get { return (System.Single)this["SteeringWheelPctDamper"]; }
        }

        /// <summary>
        /// Force feedback limiter strength limits impacts and oscillation
        /// </summary>
        public System.Single SteeringWheelLimiter
        {
            get { return (System.Single)this["SteeringWheelLimiter"]; }
        }

        /// <summary>
        /// Value of strength or max force slider in Nm for FFB
        /// </summary>
        public System.Single SteeringWheelMaxForceNm
        {
            get { return (System.Single)this["SteeringWheelMaxForceNm"]; }
        }

        /// <summary>
        /// Peak torque mapping to direct input units for FFB
        /// </summary>
        public System.Single SteeringWheelPeakForceNm
        {
            get { return (System.Single)this["SteeringWheelPeakForceNm"]; }
        }

        /// <summary>
        /// True if steering wheel force is using linear mode
        /// </summary>
        public System.Boolean SteeringWheelUseLinear
        {
            get { return (System.Boolean)this["SteeringWheelUseLinear"]; }
        }

        /// <summary>
        /// DEPRECATED use DriverCarSLBlinkRPM instead
        /// </summary>
        public System.Single ShiftIndicatorPct
        {
            get { return (System.Single)this["ShiftIndicatorPct"]; }
        }

        /// <summary>
        /// Replay playback speed
        /// </summary>
        public System.Int32 ReplayPlaySpeed
        {
            get { return (System.Int32)this["ReplayPlaySpeed"]; }
        }

        /// <summary>
        /// 0=not slow motion  1=replay is in slow motion
        /// </summary>
        public System.Boolean ReplayPlaySlowMotion
        {
            get { return (System.Boolean)this["ReplayPlaySlowMotion"]; }
        }

        /// <summary>
        /// Seconds since replay session start
        /// </summary>
        public System.Double ReplaySessionTime
        {
            get { return (System.Double)this["ReplaySessionTime"]; }
        }

        /// <summary>
        /// Replay session number
        /// </summary>
        public System.Int32 ReplaySessionNum
        {
            get { return (System.Int32)this["ReplaySessionNum"]; }
        }

        /// <summary>
        /// Players LF Tire Sound rumblestrip pitch
        /// </summary>
        public System.Single TireLF_RumblePitch
        {
            get { return (System.Single)this["TireLF_RumblePitch"]; }
        }

        /// <summary>
        /// Players RF Tire Sound rumblestrip pitch
        /// </summary>
        public System.Single TireRF_RumblePitch
        {
            get { return (System.Single)this["TireRF_RumblePitch"]; }
        }

        /// <summary>
        /// Players LR Tire Sound rumblestrip pitch
        /// </summary>
        public System.Single TireLR_RumblePitch
        {
            get { return (System.Single)this["TireLR_RumblePitch"]; }
        }

        /// <summary>
        /// Players RR Tire Sound rumblestrip pitch
        /// </summary>
        public System.Single TireRR_RumblePitch
        {
            get { return (System.Single)this["TireRR_RumblePitch"]; }
        }

        /// <summary>
        /// 1=Garage screen is visible
        /// </summary>
        public System.Boolean IsGarageVisible
        {
            get { return (System.Boolean)this["IsGarageVisible"]; }
        }

        /// <summary>
        /// Output torque on steering shaft at 360 Hz
        /// </summary>
        public System.Single[] SteeringWheelTorque_ST
        {
            get { return (System.Single[])this["SteeringWheelTorque_ST"]; }
        }

        /// <summary>
        /// Output torque on steering shaft
        /// </summary>
        public System.Single SteeringWheelTorque
        {
            get { return (System.Single)this["SteeringWheelTorque"]; }
        }

        /// <summary>
        /// Z velocity
        /// </summary>
        public System.Single[] VelocityZ_ST
        {
            get { return (System.Single[])this["VelocityZ_ST"]; }
        }

        /// <summary>
        /// Y velocity
        /// </summary>
        public System.Single[] VelocityY_ST
        {
            get { return (System.Single[])this["VelocityY_ST"]; }
        }

        /// <summary>
        /// X velocity
        /// </summary>
        public System.Single[] VelocityX_ST
        {
            get { return (System.Single[])this["VelocityX_ST"]; }
        }

        /// <summary>
        /// Z velocity
        /// </summary>
        public System.Single VelocityZ
        {
            get { return (System.Single)this["VelocityZ"]; }
        }

        /// <summary>
        /// Y velocity
        /// </summary>
        public System.Single VelocityY
        {
            get { return (System.Single)this["VelocityY"]; }
        }

        /// <summary>
        /// X velocity
        /// </summary>
        public System.Single VelocityX
        {
            get { return (System.Single)this["VelocityX"]; }
        }

        /// <summary>
        /// Yaw rate at 360 Hz
        /// </summary>
        public System.Single[] YawRate_ST
        {
            get { return (System.Single[])this["YawRate_ST"]; }
        }

        /// <summary>
        /// Pitch rate at 360 Hz
        /// </summary>
        public System.Single[] PitchRate_ST
        {
            get { return (System.Single[])this["PitchRate_ST"]; }
        }

        /// <summary>
        /// Roll rate at 360 Hz
        /// </summary>
        public System.Single[] RollRate_ST
        {
            get { return (System.Single[])this["RollRate_ST"]; }
        }

        /// <summary>
        /// Yaw rate
        /// </summary>
        public System.Single YawRate
        {
            get { return (System.Single)this["YawRate"]; }
        }

        /// <summary>
        /// Pitch rate
        /// </summary>
        public System.Single PitchRate
        {
            get { return (System.Single)this["PitchRate"]; }
        }

        /// <summary>
        /// Roll rate
        /// </summary>
        public System.Single RollRate
        {
            get { return (System.Single)this["RollRate"]; }
        }

        /// <summary>
        /// Vertical acceleration (including gravity) at 360 Hz
        /// </summary>
        public System.Single[] VertAccel_ST
        {
            get { return (System.Single[])this["VertAccel_ST"]; }
        }

        /// <summary>
        /// Lateral acceleration (including gravity) at 360 Hz
        /// </summary>
        public System.Single[] LatAccel_ST
        {
            get { return (System.Single[])this["LatAccel_ST"]; }
        }

        /// <summary>
        /// Longitudinal acceleration (including gravity) at 360 Hz
        /// </summary>
        public System.Single[] LongAccel_ST
        {
            get { return (System.Single[])this["LongAccel_ST"]; }
        }

        /// <summary>
        /// Vertical acceleration (including gravity)
        /// </summary>
        public System.Single VertAccel
        {
            get { return (System.Single)this["VertAccel"]; }
        }

        /// <summary>
        /// Lateral acceleration (including gravity)
        /// </summary>
        public System.Single LatAccel
        {
            get { return (System.Single)this["LatAccel"]; }
        }

        /// <summary>
        /// Longitudinal acceleration (including gravity)
        /// </summary>
        public System.Single LongAccel
        {
            get { return (System.Single)this["LongAccel"]; }
        }

        /// <summary>
        /// In car trigger car starter
        /// </summary>
        public System.Boolean dcStarter
        {
            get { return (System.Boolean)this["dcStarter"]; }
        }

        /// <summary>
        /// In car traction control active
        /// </summary>
        public System.Boolean dcPitSpeedLimiterToggle
        {
            get { return (System.Boolean)this["dcPitSpeedLimiterToggle"]; }
        }

        /// <summary>
        /// In car headlight flash control active
        /// </summary>
        public System.Boolean dcHeadlightFlash
        {
            get { return (System.Boolean)this["dcHeadlightFlash"]; }
        }

        /// <summary>
        /// Pitstop rf tire change request
        /// </summary>
        public System.Single dpRFTireChange
        {
            get { return (System.Single)this["dpRFTireChange"]; }
        }

        /// <summary>
        /// Pitstop lf tire change request
        /// </summary>
        public System.Single dpLFTireChange
        {
            get { return (System.Single)this["dpLFTireChange"]; }
        }

        /// <summary>
        /// Pitstop rr tire change request
        /// </summary>
        public System.Single dpRRTireChange
        {
            get { return (System.Single)this["dpRRTireChange"]; }
        }

        /// <summary>
        /// Pitstop lr tire change request
        /// </summary>
        public System.Single dpLRTireChange
        {
            get { return (System.Single)this["dpLRTireChange"]; }
        }

        /// <summary>
        /// Pitstop fuel fill flag
        /// </summary>
        public System.Single dpFuelFill
        {
            get { return (System.Single)this["dpFuelFill"]; }
        }

        /// <summary>
        /// Pitstop windshield tearoff
        /// </summary>
        public System.Single dpWindshieldTearoff
        {
            get { return (System.Single)this["dpWindshieldTearoff"]; }
        }

        /// <summary>
        /// Pitstop fuel add amount
        /// </summary>
        public System.Single dpFuelAddKg
        {
            get { return (System.Single)this["dpFuelAddKg"]; }
        }

        /// <summary>
        /// Pitstop fast repair set
        /// </summary>
        public System.Single dpFastRepair
        {
            get { return (System.Single)this["dpFastRepair"]; }
        }

        /// <summary>
        /// In car brake bias adjustment
        /// </summary>
        public System.Single dcBrakeBias
        {
            get { return (System.Single)this["dcBrakeBias"]; }
        }

        /// <summary>
        /// Pitstop lf tire cold pressure adjustment
        /// </summary>
        public System.Single dpLFTireColdPress
        {
            get { return (System.Single)this["dpLFTireColdPress"]; }
        }

        /// <summary>
        /// Pitstop rf cold tire pressure adjustment
        /// </summary>
        public System.Single dpRFTireColdPress
        {
            get { return (System.Single)this["dpRFTireColdPress"]; }
        }

        /// <summary>
        /// Pitstop lr tire cold pressure adjustment
        /// </summary>
        public System.Single dpLRTireColdPress
        {
            get { return (System.Single)this["dpLRTireColdPress"]; }
        }

        /// <summary>
        /// Pitstop rr cold tire pressure adjustment
        /// </summary>
        public System.Single dpRRTireColdPress
        {
            get { return (System.Single)this["dpRRTireColdPress"]; }
        }

        /// <summary>
        /// In car traction control adjustment
        /// </summary>
        public System.Single dcTractionControl
        {
            get { return (System.Single)this["dcTractionControl"]; }
        }

        /// <summary>
        /// In car abs adjustment
        /// </summary>
        public System.Single dcABS
        {
            get { return (System.Single)this["dcABS"]; }
        }

        /// <summary>
        /// Engine fuel used instantaneous
        /// </summary>
        public System.Single FuelUsePerHour
        {
            get { return (System.Single)this["FuelUsePerHour"]; }
        }

        /// <summary>
        /// Engine voltage
        /// </summary>
        public System.Single Voltage
        {
            get { return (System.Single)this["Voltage"]; }
        }

        /// <summary>
        /// Engine coolant temp
        /// </summary>
        public System.Single WaterTemp
        {
            get { return (System.Single)this["WaterTemp"]; }
        }

        /// <summary>
        /// Engine coolant level
        /// </summary>
        public System.Single WaterLevel
        {
            get { return (System.Single)this["WaterLevel"]; }
        }

        /// <summary>
        /// Engine fuel pressure
        /// </summary>
        public System.Single FuelPress
        {
            get { return (System.Single)this["FuelPress"]; }
        }

        /// <summary>
        /// Engine oil temperature
        /// </summary>
        public System.Single OilTemp
        {
            get { return (System.Single)this["OilTemp"]; }
        }

        /// <summary>
        /// Engine oil pressure
        /// </summary>
        public System.Single OilPress
        {
            get { return (System.Single)this["OilPress"]; }
        }

        /// <summary>
        /// Engine oil level
        /// </summary>
        public System.Single OilLevel
        {
            get { return (System.Single)this["OilLevel"]; }
        }

        /// <summary>
        /// Engine manifold pressure
        /// </summary>
        public System.Single ManifoldPress
        {
            get { return (System.Single)this["ManifoldPress"]; }
        }

        /// <summary>
        /// Liters of fuel remaining
        /// </summary>
        public System.Single FuelLevel
        {
            get { return (System.Single)this["FuelLevel"]; }
        }

        /// <summary>
        /// Engine0Engine rpm
        /// </summary>
        public System.Single Engine0_RPM
        {
            get { return (System.Single)this["Engine0_RPM"]; }
        }

        /// <summary>
        /// RF brake line pressure
        /// </summary>
        public System.Single RFbrakeLinePress
        {
            get { return (System.Single)this["RFbrakeLinePress"]; }
        }

        /// <summary>
        /// RF tire cold pressure  as set in the garage
        /// </summary>
        public System.Single RFcoldPressure
        {
            get { return (System.Single)this["RFcoldPressure"]; }
        }

        /// <summary>
        /// RF tire left carcass temperature
        /// </summary>
        public System.Single RFtempCL
        {
            get { return (System.Single)this["RFtempCL"]; }
        }

        /// <summary>
        /// RF tire middle carcass temperature
        /// </summary>
        public System.Single RFtempCM
        {
            get { return (System.Single)this["RFtempCM"]; }
        }

        /// <summary>
        /// RF tire right carcass temperature
        /// </summary>
        public System.Single RFtempCR
        {
            get { return (System.Single)this["RFtempCR"]; }
        }

        /// <summary>
        /// RF tire left percent tread remaining
        /// </summary>
        public System.Single RFwearL
        {
            get { return (System.Single)this["RFwearL"]; }
        }

        /// <summary>
        /// RF tire middle percent tread remaining
        /// </summary>
        public System.Single RFwearM
        {
            get { return (System.Single)this["RFwearM"]; }
        }

        /// <summary>
        /// RF tire right percent tread remaining
        /// </summary>
        public System.Single RFwearR
        {
            get { return (System.Single)this["RFwearR"]; }
        }

        /// <summary>
        /// LF brake line pressure
        /// </summary>
        public System.Single LFbrakeLinePress
        {
            get { return (System.Single)this["LFbrakeLinePress"]; }
        }

        /// <summary>
        /// LF tire cold pressure  as set in the garage
        /// </summary>
        public System.Single LFcoldPressure
        {
            get { return (System.Single)this["LFcoldPressure"]; }
        }

        /// <summary>
        /// LF tire left carcass temperature
        /// </summary>
        public System.Single LFtempCL
        {
            get { return (System.Single)this["LFtempCL"]; }
        }

        /// <summary>
        /// LF tire middle carcass temperature
        /// </summary>
        public System.Single LFtempCM
        {
            get { return (System.Single)this["LFtempCM"]; }
        }

        /// <summary>
        /// LF tire right carcass temperature
        /// </summary>
        public System.Single LFtempCR
        {
            get { return (System.Single)this["LFtempCR"]; }
        }

        /// <summary>
        /// LF tire left percent tread remaining
        /// </summary>
        public System.Single LFwearL
        {
            get { return (System.Single)this["LFwearL"]; }
        }

        /// <summary>
        /// LF tire middle percent tread remaining
        /// </summary>
        public System.Single LFwearM
        {
            get { return (System.Single)this["LFwearM"]; }
        }

        /// <summary>
        /// LF tire right percent tread remaining
        /// </summary>
        public System.Single LFwearR
        {
            get { return (System.Single)this["LFwearR"]; }
        }

        /// <summary>
        /// RR brake line pressure
        /// </summary>
        public System.Single RRbrakeLinePress
        {
            get { return (System.Single)this["RRbrakeLinePress"]; }
        }

        /// <summary>
        /// RR tire cold pressure  as set in the garage
        /// </summary>
        public System.Single RRcoldPressure
        {
            get { return (System.Single)this["RRcoldPressure"]; }
        }

        /// <summary>
        /// RR tire left carcass temperature
        /// </summary>
        public System.Single RRtempCL
        {
            get { return (System.Single)this["RRtempCL"]; }
        }

        /// <summary>
        /// RR tire middle carcass temperature
        /// </summary>
        public System.Single RRtempCM
        {
            get { return (System.Single)this["RRtempCM"]; }
        }

        /// <summary>
        /// RR tire right carcass temperature
        /// </summary>
        public System.Single RRtempCR
        {
            get { return (System.Single)this["RRtempCR"]; }
        }

        /// <summary>
        /// RR tire left percent tread remaining
        /// </summary>
        public System.Single RRwearL
        {
            get { return (System.Single)this["RRwearL"]; }
        }

        /// <summary>
        /// RR tire middle percent tread remaining
        /// </summary>
        public System.Single RRwearM
        {
            get { return (System.Single)this["RRwearM"]; }
        }

        /// <summary>
        /// RR tire right percent tread remaining
        /// </summary>
        public System.Single RRwearR
        {
            get { return (System.Single)this["RRwearR"]; }
        }

        /// <summary>
        /// LR brake line pressure
        /// </summary>
        public System.Single LRbrakeLinePress
        {
            get { return (System.Single)this["LRbrakeLinePress"]; }
        }

        /// <summary>
        /// LR tire cold pressure  as set in the garage
        /// </summary>
        public System.Single LRcoldPressure
        {
            get { return (System.Single)this["LRcoldPressure"]; }
        }

        /// <summary>
        /// LR tire left carcass temperature
        /// </summary>
        public System.Single LRtempCL
        {
            get { return (System.Single)this["LRtempCL"]; }
        }

        /// <summary>
        /// LR tire middle carcass temperature
        /// </summary>
        public System.Single LRtempCM
        {
            get { return (System.Single)this["LRtempCM"]; }
        }

        /// <summary>
        /// LR tire right carcass temperature
        /// </summary>
        public System.Single LRtempCR
        {
            get { return (System.Single)this["LRtempCR"]; }
        }

        /// <summary>
        /// LR tire left percent tread remaining
        /// </summary>
        public System.Single LRwearL
        {
            get { return (System.Single)this["LRwearL"]; }
        }

        /// <summary>
        /// LR tire middle percent tread remaining
        /// </summary>
        public System.Single LRwearM
        {
            get { return (System.Single)this["LRwearM"]; }
        }

        /// <summary>
        /// LR tire right percent tread remaining
        /// </summary>
        public System.Single LRwearR
        {
            get { return (System.Single)this["LRwearR"]; }
        }

        /// <summary>
        /// LR shock deflection
        /// </summary>
        public System.Single LRshockDefl
        {
            get { return (System.Single)this["LRshockDefl"]; }
        }

        /// <summary>
        /// LR shock deflection at 360 Hz
        /// </summary>
        public System.Single[] LRshockDefl_ST
        {
            get { return (System.Single[])this["LRshockDefl_ST"]; }
        }

        /// <summary>
        /// LR shock velocity
        /// </summary>
        public System.Single LRshockVel
        {
            get { return (System.Single)this["LRshockVel"]; }
        }

        /// <summary>
        /// LR shock velocity at 360 Hz
        /// </summary>
        public System.Single[] LRshockVel_ST
        {
            get { return (System.Single[])this["LRshockVel_ST"]; }
        }

        /// <summary>
        /// RR shock deflection
        /// </summary>
        public System.Single RRshockDefl
        {
            get { return (System.Single)this["RRshockDefl"]; }
        }

        /// <summary>
        /// RR shock deflection at 360 Hz
        /// </summary>
        public System.Single[] RRshockDefl_ST
        {
            get { return (System.Single[])this["RRshockDefl_ST"]; }
        }

        /// <summary>
        /// RR shock velocity
        /// </summary>
        public System.Single RRshockVel
        {
            get { return (System.Single)this["RRshockVel"]; }
        }

        /// <summary>
        /// RR shock velocity at 360 Hz
        /// </summary>
        public System.Single[] RRshockVel_ST
        {
            get { return (System.Single[])this["RRshockVel_ST"]; }
        }

        /// <summary>
        /// LF shock deflection
        /// </summary>
        public System.Single LFshockDefl
        {
            get { return (System.Single)this["LFshockDefl"]; }
        }

        /// <summary>
        /// LF shock deflection at 360 Hz
        /// </summary>
        public System.Single[] LFshockDefl_ST
        {
            get { return (System.Single[])this["LFshockDefl_ST"]; }
        }

        /// <summary>
        /// LF shock velocity
        /// </summary>
        public System.Single LFshockVel
        {
            get { return (System.Single)this["LFshockVel"]; }
        }

        /// <summary>
        /// LF shock velocity at 360 Hz
        /// </summary>
        public System.Single[] LFshockVel_ST
        {
            get { return (System.Single[])this["LFshockVel_ST"]; }
        }

        /// <summary>
        /// RF shock deflection
        /// </summary>
        public System.Single RFshockDefl
        {
            get { return (System.Single)this["RFshockDefl"]; }
        }

        /// <summary>
        /// RF shock deflection at 360 Hz
        /// </summary>
        public System.Single[] RFshockDefl_ST
        {
            get { return (System.Single[])this["RFshockDefl_ST"]; }
        }

        /// <summary>
        /// RF shock velocity
        /// </summary>
        public System.Single RFshockVel
        {
            get { return (System.Single)this["RFshockVel"]; }
        }

        /// <summary>
        /// RF shock velocity at 360 Hz
        /// </summary>
        public System.Single[] RFshockVel_ST
        {
            get { return (System.Single[])this["RFshockVel_ST"]; }
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 TickCount
        {
            get { return (System.Int32)this["TickCount"]; }
        }
    }
}