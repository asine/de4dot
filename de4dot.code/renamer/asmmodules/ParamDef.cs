﻿/*
    Copyright (C) 2011-2012 de4dot@gmail.com

    This file is part of de4dot.

    de4dot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    de4dot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with de4dot.  If not, see <http://www.gnu.org/licenses/>.
*/

using dot10.DotNet;

namespace de4dot.code.renamer.asmmodules {
	class MParamDef {
		public Parameter ParameterDefinition { get; set; }
		public int Index { get; private set; }
		public bool IsReturnParameter {
			get { return Index < 0; }
		}

		public MParamDef(Parameter parameterDefinition, int index) {
			this.ParameterDefinition = parameterDefinition;
			Index = index;
		}
	}
}
