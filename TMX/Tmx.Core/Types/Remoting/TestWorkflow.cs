﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/8/2014
 * Time: 9:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx.Core.Types.Remoting
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Remoting;
    using Interfaces.Remoting.Actions;

    /// <summary>
    /// Description of TestWorkflow.
    /// </summary>
    public class TestWorkflow : ITestWorkflow
    {
        ITestLab _testLab;
        
        public TestWorkflow(ITestLab testLab)
        {
            Id = Guid.NewGuid();
            _testLab = testLab;
            DefaultData = new CommonData();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TestLabId {
            get { return _testLab.Id; }
        }
        
        public void SetTestLab(ITestLab testLab)
        {
            _testLab = testLab;
        }
        
        public string ParametersPageName { get; set; }
        public string Path { get; set; }
        public ICommonData DefaultData { get; set; }
        public bool IsDefault { get; set; }

        public List<IAction> BeforeActions { get; set; }
        public List<IAction> AfterActions { get; set; }
        public List<IAction> CancelActions { get; set; }
        public List<IAction> FailureActions { get; set; }
    }
}
