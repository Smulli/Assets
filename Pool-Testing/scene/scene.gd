extends RecyclableScene

class_name Controller

const DIR := Vector3.UP
	
func _process(delta) :
	if get_parent().stop :
		return

	var speed = speed_meter * delta
	
	get_parent().translate(DIR * speed)
