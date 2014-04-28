---------------------------------------------------------------------------------------
-- A simple physics example in 8 lines!
---------------------------------------------------------------------------------------

local physics = require( "physics" )
physics.start()

local sky = display.newImage( "sky.png", 160, 195 )
local ground = display.newImage( "ground.png", 160, 445 )

local crate = display.newImage( "crate.png", 180, -50 )
crate.rotation = 5

physics.addBody( ground, "static", { friction=0.5, bounce=0.3 } )
physics.addBody( crate, { density=3.0, friction=0.5, bounce=0.3 } )

local ui = require("ui")

local on1Touched = function(event)
	if ( event.phase == "press" ) then
        local event = { name = "coronaView", message="Hello from CoronaCards!" }
        --dispatch the event to the global Runtime object
        local result = Runtime:dispatchEvent( event )
        print( "Response: " .. result ) --> Response: Nice to meet you CoronaCards!
    end
    return true
end

local mButton = ui.newButton{
	defaultSrc = "",
	defaultX=120,
	defaultY=50,
	overSrc = "",
	overX=120,
	overY=50,
	onEvent = on1Touched,
	id="CoronaButton",
	text="Corona Button",
	font = native.systemfont,
	textColor = {255,255,255,255},
	size=16,
	emboss=false
}

mButton.x=160
mButton.y=131


local function handlePause( event )
    if ( event.phase == "pause" ) then
        print(event.name ) --> pauseEvent
        print(event.otherKey ) --> otherValue
    end
    return true
end

Runtime:addEventListener( "pauseEvent", handlePause )
