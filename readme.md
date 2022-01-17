This simple app establishes explicit messaging communication between client and server. In real world apllications, the controller (PLC) is called the client and the field devices are called servers. 

## Server

Since I do not have two computers, to set up a remote server [vmware workstation pro](https://www.vmware.com/ca/products/workstation-pro/workstation-pro-evaluation.html) virtual machine was used. Inside vmware, I used free the PLC programming software [Do-more PLC](https://www.automationdirect.com/adc/overview/catalog/programmable_controllers/do-more_series_(brx,_h2,_t1h)_plcs_(micro_modular_-a-_stackable)). Do-more PLC allows users to create PLC code, use the simulator and establish Ethernet-ip communicatoin for free. 

## Client

The C# app acts as the client which gets explicit data from the remote server. In excplicit messaging, client request has all the information needed to respond explicitly to the message. In this app, the client requests two interger values of V40 and V41 from the server's memory block. The code was written using 
[EEIP.NET library](https://sourceforge.net/projects/eeip-net/).




![ethernetIP](https://user-images.githubusercontent.com/80297807/149717877-202d3039-b772-43fd-8c71-13520ea20206.png)
