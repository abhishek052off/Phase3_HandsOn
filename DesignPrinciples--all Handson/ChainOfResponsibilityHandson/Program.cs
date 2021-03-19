using System;

namespace ChainOfResponsibilityHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest request = new LeaveRequest();
            request.Employee = "Mark";
            request.LeaveDays = 28;

            ILeaveRequestHandler supervisor = new Supervisor();
            ILeaveRequestHandler manager = new ProjectManager();
            ILeaveRequestHandler hr = new HR();
            supervisor.nextHandler = manager;
            manager.nextHandler = hr;

            supervisor.HandleRequest(request);
            request.LeaveDays = 11;
            supervisor.HandleRequest(request);
            request.LeaveDays = 3;
            supervisor.HandleRequest(request);

            Console.ReadLine();
        }
    }
}
