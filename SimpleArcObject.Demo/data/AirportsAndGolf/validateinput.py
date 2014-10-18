# validate model input

import arcpy

infcs = arcpy.GetParameterAsText(0)
infcs = str(infcs).split(";")

try:
    arcpy.SetParameterAsText(1, True)
    for infc in infcs:
        dsc = arcpy.Describe(infc)
        if dsc.shapeType == "Point":
            arcpy.AddMessage("Input " + infc + " is Point type")
        else:
            arcpy.AddError("Invalid input " + infc + " : feature type must be Point")
            arcpy.SetParameterAsText(1, False)
except:
    arcpy.AddError("Exception occurred - debug the source script")
