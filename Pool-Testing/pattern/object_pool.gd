extends Node3D

class_name ObjectPool

var pool := []
var init_amount : int
var scene : PackedScene
signal recycle_object

func _init(Scene : PackedScene, Init_amount : int) :
	scene = Scene
	init_amount = Init_amount

func _ready() :
	for i in range(init_amount) :
		pool.append(create_new_instance())
		
func create_new_instance() :
	var instance = scene.instantiate()
	instance.configure(self)
	instance.stop = true
	instance.visible = false
		
	add_child(instance)
	
	return instance
	
func get_instance() :
	var instance
	
	if pool.size() > 0 :
		instance = pool.pop_back()
		instance.show()
		instance.stop = false
	else :
		instance = create_new_instance()
		instance.show()
		instance.stop = false
		
	return instance
		
func recyclable_instance(instance) :
	recycle_object.emit(instance)
	pool.append(instance)
