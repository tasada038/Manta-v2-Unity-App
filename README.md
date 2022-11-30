# Manta v2 Unity App
This is a package for simulating URDF robots with Unity and ROS2

![Unity Image](/image/unity_joint_sim.png)

## Operation confirmed environment
- Laptop PC
	- Ubuntu 20.04
	- ROS2 Foxy
	- intel CORE i7
	- GEFORCE RTX 3070
 
 - Unity Hub 3.3.0
 - Unity 2021.3.8f1

<br>

## Install
If you have not installed the 'manta_v2_bringup' package, run the following command to install the manta_v2_bringup package.

```
mkdir -p ~/manta_ws/src
cd ~/manta_ws/src
git clone https://github.com/tasada038/manta_v2.git
cd ~/manta_ws && colcon build --symlink-install
```

<br>

## Usage
Open two shells. In the first shell,run the following:
```
ros2 run ros_tcp_endpoint default_server_endpoint --ros-args -p ROS_IP:=0.0.0.0
```

In the second shell, run the manta_bringup launch file:
```
ros2 launch manta_v2_bringup manta_bringup.launch.py
```

<br>

## License
This repository is licensed under the Apache 2.0, see LICENSE for details.