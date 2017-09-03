﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Threading;
using dnSpy.Contracts.Debugger.DotNet.Evaluation;
using dnSpy.Contracts.Debugger.DotNet.Evaluation.ExpressionCompiler;
using dnSpy.Contracts.Debugger.Evaluation;

namespace dnSpy.Roslyn.Shared.Debugger.ExpressionEvaluator {
	[ExportDbgDotNetExpressionCompiler(DbgDotNetLanguageGuids.CSharp, PredefinedDbgLanguageNames.CSharp, "C#", PredefinedDecompilerGuids.CSharp)]
	sealed class CSharpExpressionCompiler : DbgDotNetExpressionCompiler {
		public override DbgDotNetCompilationResult CompileAssignment(DbgEvaluationContext context, DbgModuleReference[] references, DbgDotNetAlias[] aliases, string target, string expression, DbgEvaluationOptions options, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override DbgDotNetCompilationResult CompileGetLocals(DbgEvaluationContext context, DbgModuleReference[] references, DbgEvaluationOptions options, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override DbgDotNetCompilationResult CompileExpressions(DbgEvaluationContext context, DbgModuleReference[] references, DbgDotNetAlias[] aliases, string[] expressions, DbgEvaluationOptions options, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}
	}
}