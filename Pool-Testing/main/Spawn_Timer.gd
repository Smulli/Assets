extends Timer

class_name SpawnTimer

func _ready() :
	self.start(1)
	self.timeout.connect(func() : get_parent().spawn())
