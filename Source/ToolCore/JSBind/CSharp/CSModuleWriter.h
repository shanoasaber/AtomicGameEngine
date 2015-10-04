//
// Copyright (c) 2014-2015, THUNDERBEAST GAMES LLC All rights reserved
// LICENSE: Atomic Game Engine Editor and Tools EULA
// Please see LICENSE_ATOMIC_EDITOR_AND_TOOLS.md in repository root for
// license information: https://github.com/AtomicGameEngine/AtomicGameEngine
//

#pragma once

#include <Atomic/Container/Str.h>

#include "../JSBModuleWriter.h"

using namespace Atomic;

namespace ToolCore
{

class JSBModule;

class CSModuleWriter : public JSBModuleWriter
{

public:

    CSModuleWriter(JSBModule* module);

    void GenerateSource();

    void GenerateNativeSource();
    void GenerateManagedSource();


private:

    void GenerateNativeThunkInit(String& sourceOut);

    String GetManagedPrimitiveType(JSBPrimitiveType* ptype);

    void GenerateManagedModuleClass(String& sourceOut);
    void GenerateManagedClasses(String& source);
    void GenerateManagedEnumsAndConstants(String& source);


    void WriteIncludes(String& source);

};

}
