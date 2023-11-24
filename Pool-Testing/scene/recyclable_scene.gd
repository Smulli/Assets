extends Node3D

class_name RecyclableScene

var pool : ObjectPool
@export var speed_meter : float
@export var stop : bool 

func configure(p : ObjectPool) :
	self.pool = p
	p.recycle_object.connect(on_recycle)
	
func _process(delta) :
	if self.position.y > 10 :
		self.pool.recyclable_instance(self)
		self.stop = true

func on_recycle(target) :
	if target != self :
		return
	self.global_position = Vector3(0, 0, 0)
	self.visible = false
