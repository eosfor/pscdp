#!/bin/bash
echo "Starting Chromium..." >> /tmp/chromium-start.log
/usr/bin/chromium --headless --no-sandbox --disable-gpu --remote-debugging-port=9222 >> /tmp/chromium.log 2>&1 &
echo "Chromium launched with PID $!" >> /tmp/chromium-start.log